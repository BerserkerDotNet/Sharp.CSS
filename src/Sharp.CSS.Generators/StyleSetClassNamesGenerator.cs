using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Sharp.CSS.Generators
{
    [Generator]
    public class StyleSetClassNamesGenerator : ISourceGenerator
    {
        private const string SharpCSS = "SharpCSS";
        private const string CssStyleServiceType = "Sharp.CSS.Interfaces.ICssStyleService";
        private const string CssStyleServiceConfiguratorType = "Sharp.CSS.Blazor.SharpCssConfigurator";
        private const string StyleSetType = "Sharp.CSS.CssStyleSets.StyleSet";

        public void Initialize(GeneratorInitializationContext context)
        {
        }

        public void Execute(GeneratorExecutionContext context)
        {
            var compilation = context.Compilation;
            var cssServiceType = compilation.GetTypeByMetadataName(CssStyleServiceType);
            var cssServiceConfiguratorType = compilation.GetTypeByMetadataName(CssStyleServiceConfiguratorType);

            var toGenerate = new List<TypeToGenerate>();
            foreach (var tree in compilation.SyntaxTrees)
            {
                var semanticModel = compilation.GetSemanticModel(tree);
                var typesToGenerate = FindTypesToGenerate(tree, semanticModel, context, cssServiceType, cssServiceConfiguratorType);
                toGenerate.AddRange(typesToGenerate); // TODO: Handle duplicate type names
            }

            var source = GenerateCode(toGenerate);
            context.AddSource("Sharp.CSS.Types.Generated.cs", SourceText.From(source, Encoding.UTF8));
        }

        private string GenerateCode(IEnumerable<TypeToGenerate> typesToGenerate)
        {
            var source = new StringBuilder();
            source.AppendLine("namespace Sharp.CSS.Types.Generated");
            source.AppendLine("{");
            foreach (var item in typesToGenerate)
            {
                source.AppendLine($"\tpublic class {item.Name}");
                source.AppendLine("\t{");
                foreach (var property in item.Properties)
                {
                    source.AppendLine($"\t\tpublic string {property} {{ get; private set; }}");
                }

                source.AppendLine("\t}");
                source.AppendLine();
            }

            source.AppendLine("}");

            return source.ToString();
        }

        private IEnumerable<TypeToGenerate> FindTypesToGenerate(SyntaxTree tree, SemanticModel model, GeneratorExecutionContext context, INamedTypeSymbol cssServiceType, INamedTypeSymbol cssServiceConfiguratorType)
        {
            var methodInvocations = tree.GetRoot().DescendantNodesAndSelf().OfType<InvocationExpressionSyntax>();
            foreach (var invocation in methodInvocations)
            {
                var symbol = model.GetSymbolInfo(invocation).Symbol as IMethodSymbol;
                if (symbol is null || !invocation.ArgumentList.Arguments.Any())
                {
                    continue;
                }

                var isGetClassNames = SymbolEqualityComparer.Default.Equals(symbol.ContainingType, cssServiceType) && string.Equals(symbol.Name, "GetClassNames");
                var isRegisterStyles = SymbolEqualityComparer.Default.Equals(symbol.ContainingType, cssServiceConfiguratorType) && string.Equals(symbol.Name, "RegisterStyles");
                if (!isGetClassNames && !isRegisterStyles)
                {
                    continue;
                }

                var typeToGenerate = isGetClassNames ? symbol.ReturnType : symbol.TypeArguments.Single();
                var firstArgument = invocation.ArgumentList.Arguments.First().Expression;
                var expKind = firstArgument.Kind();
                if (expKind != SyntaxKind.AnonymousObjectCreationExpression &&
                    expKind != SyntaxKind.ObjectCreationExpression &&
                    expKind != SyntaxKind.IdentifierName)
                {
                    continue; // TODO: warning if argument type is weird
                }

                ITypeSymbol typeToUse;
                if (expKind == SyntaxKind.IdentifierName)
                {
                    var idSyntax = firstArgument as IdentifierNameSyntax;
                    typeToUse = model.GetTypeInfo(idSyntax.Identifier.Parent).Type;
                }
                else
                {
                    typeToUse = model.GetSymbolInfo(firstArgument).Symbol.ContainingType;
                }

                if (typeToGenerate.TypeKind != TypeKind.Error && typeToGenerate.TypeKind != TypeKind.Unknown)
                {
                    context.ReportDiagnostic(Diagnostic.Create("SCSS002", SharpCSS, $"Type '{typeToGenerate.Name}' is already defined and will not be generated.", DiagnosticSeverity.Info, DiagnosticSeverity.Info, true, 1, false));
                    continue;
                }

                var props = typeToUse.GetMembers().Where(m => m.Kind == SymbolKind.Property).ToList();
                var propertiesToGenerate = new List<string>(props.Count);
                foreach (IPropertySymbol property in props)
                {
                    if (!string.Equals($"{property.Type.ContainingNamespace}.{property.Type.Name}", StyleSetType, StringComparison.OrdinalIgnoreCase))
                    {
                        context.ReportDiagnostic(Diagnostic.Create("SCSS001", SharpCSS, $"Property '{property.Name}' is not of type `{StyleSetType}` and will be ignore.", DiagnosticSeverity.Warning, DiagnosticSeverity.Warning, true, 4, false, location: property.Locations.First()));
                        continue;
                    }

                    propertiesToGenerate.Add(property.Name);
                }

                yield return new TypeToGenerate
                {
                    Name = typeToGenerate.Name,
                    Properties = propertiesToGenerate
                };
            }
        }
    }
}
