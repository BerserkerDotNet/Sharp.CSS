# Sharp.CSS

`Sharp.CSS` provides a way to write CSS in C# and it generates classes on the fly.

![deployment](https://github.com/BerserkerDotNet/Sharp.CSS/workflows/deployment/badge.svg?branch=master)

[![Nuget](https://buildstats.info/nuget/Sharp.CSS?v=0.1.1-alpha)](https://www.nuget.org/packages/Sharp.CSS)
[![Nuget](https://buildstats.info/nuget/Sharp.CSS.Blazor?v=0.1.1-alpha)](https://www.nuget.org/packages/Sharp.CSS.Blazor)

## Usage

### Blazor

1. Install `Sharp.CSS.Blazor` package
1. Add the following namespaces to the _Import.razor file.
   
   `@using Sharp.CSS.Interfaces`
   
   `@using Sharp.CSS.CssStyleSets`
   
   `@using Sharp.CSS.Samples`
   
   `@using Sharp.CSS.Samples.Shared`
   
   `@using Sharp.CSS.Blazor`
   
1. Add `<SharpCssStyles />` component to the App.razor file.
1. In the page/component inject the css service `@inject ICssStyleService CssService`
1. Use `GetClassName` to get the css class name
```html
<p class="@CssService.GetClassName(new StyleSet
           {
            FontWeight = "bold"
           }, "counter")">Current count: @currentCount</p>
```

See samples for more details.
