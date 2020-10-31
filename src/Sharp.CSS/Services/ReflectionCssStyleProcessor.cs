﻿using Sharp.CSS.CssStyleSets;
using Sharp.CSS.Interfaces;
using System;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace Sharp.CSS.Services
{
    public class ReflectionCssStyleProcessor : ICssStyleProcessor
    {
        private static Regex _nameParser = new Regex("[A-Z][a-z]+", RegexOptions.Compiled);
        private static PropertyInfo[] _styleSetProperties;

        static ReflectionCssStyleProcessor()
        {
            _styleSetProperties = typeof(StyleSet)
                .GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .Where(p => !string.Equals(p.Name, nameof(StyleSet.DynamicProperties), StringComparison.OrdinalIgnoreCase))
                .ToArray();
        }

        public string Process(string className, StyleSet set)
        {
            if (string.IsNullOrWhiteSpace(className)) 
            {
                throw new ArgumentNullException(nameof(className));
            }

            if (set is null)
            {
                throw new ArgumentNullException(nameof(set));
            }

            var dynamicProperties = set.DynamicProperties.Select(d => (Name: d.Key, Value: (object)d.Value));
            var propertiesWithValues = _styleSetProperties
                .Select(p => (p.Name, Value: p.GetValue(set)))
                .Where(p => p.Value is object)
                .ToList();

            propertiesWithValues.AddRange(dynamicProperties);

            var cssClassBuilder = new StringBuilder();

            cssClassBuilder.AppendFormat(".{0}", className);
            cssClassBuilder.Append("{");
            foreach (var property in propertiesWithValues)
            {
                var matches = _nameParser.Matches(property.Name);
                var propertyName = matches.Any() ? string.Join("-", matches.Select(m => m.Value.ToLower())) : property.Name;

                cssClassBuilder.AppendFormat("{0}: {1};", propertyName, property.Value);
            }
            cssClassBuilder.Append("}");

            return cssClassBuilder.ToString();
        }
    }
}
