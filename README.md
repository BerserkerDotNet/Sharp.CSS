# Sharp.CSS

Write strongly typed CSS in C#.

![deployment](https://github.com/BerserkerDotNet/Sharp.CSS/workflows/deployment/badge.svg?branch=master)

[![Nuget](https://buildstats.info/nuget/Sharp.CSS?v=0.1.8-alpha)](https://www.nuget.org/packages/Sharp.CSS)
[![Nuget](https://buildstats.info/nuget/Sharp.CSS.Blazor?v=0.1.8-alpha)](https://www.nuget.org/packages/Sharp.CSS.Blazor)
[![Nuget](https://buildstats.info/nuget/Sharp.CSS.Generators?v=0.1.8-alpha)](https://www.nuget.org/packages/Sharp.CSS.Generators)

## Usage

### Blazor

1. Install `Sharp.CSS.Blazor` and `Sharp.CSS.Generators` packages
1. Add the following namespaces to the _Import.razor file.

```csharp
@using Sharp.CSS.Interfaces
@using Sharp.CSS.CssStyleSets
@using Sharp.CSS.Blazor
@using Sharp.CSS.Types
@using Sharp.CSS.Types.Generated // if using generators to generate output types
```
1. Add `<SharpCssStyles />` component to the App.razor file.
1. In the `Program.cs` register SharpCSS with DI by adding `builder.Services.AddSharpCss();`

#### Generating component styles
Sharp.CSS is able to generate multiple CSS classes for your component at once:
```csharp
Styles = Css.GetClassNames<CounterStyles>(new
{
    Header = new StyleSet
    {
        FontSize = "40px"
    },
    Counter = new StyleSet
    {
        Padding = 10,
        FontWeight = "bold",
        Border = new Border(3, BorderSideStyle.Dotted, Color.Green)
    },
    Button = new StyleSet
    {
        BackgroundColor = Color.DeepSkyBlue
    }
});
```
By default Sharp.CSS will generate output class automatically if you have installed `Sharp.CSS.Generators`. Type the name of the class in the generic parameter of `GetClassNames` and it will be generated.
In the example above, generated `CounterStyles` class will look like:
```csharp
public class CounterStyles
{
    public string Header { get; private set; }
    public string Counter { get; private set; }
    public string Button { get; private set; }
}
```
Make sure to include `using Sharp.CSS.Types.Generated` everywhere you plan to use generated types.

Alternatively, if you don't want Sharp.CSS to generate output class, specify an existing class. Make sure that each `StyleSet` property on the input object, have a corresponding `string` property on the output class.

Here is an example of how to use output class in the markup:
```html
<h1 class="@Styles.Header">Counter</h1>
<p class="@Styles.Counter">Current count: @currentCount</p>
<button class="btn btn-primary @Styles.Button" @onclick="IncrementCount">Click me</button>
```

#### Injecting styles into components
The most convenient way to use styles is to inject them via dependency injection.
To do that, first the style needs to be registered with the DI. This is done in the `Program.cs` where container is configured.
`AddSharpCss` takes an optional parameter that allows to provide styles configuration.
```csharp
builder.Services.AddSharpCss(cfg =>
{
    cfg.RegisterStyles<InjectedCounterStyles>(new
    {
        Header = new StyleSet
        {
            FontSize = "80px"
        },
        Counter = new StyleSet
        {
            Padding = 40,
            FontWeight = "bold",
            Border = new Border(3, BorderSideStyle.Groove, Color.Navy)
        },
        Button = new StyleSet
        {
            BackgroundColor = Color.YellowGreen
        }
    });
});
```

Now `InjectedCounterStyles` can be injected into component via `@inject` attribute.
```html
@inject InjectedCounterStyles iStyles

<h1 class="@iStyles.Header">Counter</h1>
<p class="@iStyles.Counter">Current count: @currentCount</p>
<button class="btn btn-primary @iStyles.Button" @onclick="IncrementCount">Click me</button>
```

Styles configuration can be extracted into modules to simplify registration code.
Module is a class that implements `IStylesModule` for example:

```csharp
public class CounterStylesModule : IStylesModule
{
    public void Configure(SharpCssConfigurator configurator)
    {
        configurator.RegisterStyles<ModuleCounterStyles>(new
        {
            Header = new StyleSet
            {
                FontSize = "55px"
            },
            Counter = new StyleSet
            {
                Padding = 20,
                FontWeight = "bold",
                Border = new Border(3, BorderSideStyle.Dashed, Color.Pink)
            },
            Button = new StyleSet
            {
                BackgroundColor = Color.Magenta
            }
        });
    }
}
```

To register a module, call:
```csharp
builder.Services.AddSharpCss(cfg =>
{
    cfg.RegisterStylesModule(new CounterStylesModule());
});
```

#### Generating single CSS class

`ICssStyleService` type exposes `GetClassName` capable of generating a single CSS class.
```html
@inject ICssStyleService Css

<h1 class="@Css.GetClassName(new() { FontSize = "80px" })">Counter</h1>
```

Refer to samples for more details.
