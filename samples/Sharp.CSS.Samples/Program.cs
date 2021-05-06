using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Sharp.CSS.Blazor;
using Sharp.CSS.CssStyleSets;
using Sharp.CSS.Samples.Pages;
using Sharp.CSS.Types;
using Sharp.CSS.Types.Generated;
using System;
using System.Drawing;
using System.Net.Http;
using System.Threading.Tasks;

namespace Sharp.CSS.Samples
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddSharpCss(cfg =>
            {
                cfg.RegisterStylesModule(new CounterStylesModule());
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

            await builder.Build().RunAsync();
        }
    }
}
