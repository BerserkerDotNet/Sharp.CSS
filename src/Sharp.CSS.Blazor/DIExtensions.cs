using Microsoft.Extensions.DependencyInjection;
using Sharp.CSS.Interfaces;
using Sharp.CSS.Services;

namespace Sharp.CSS.Blazor
{
    public static class DIExtensions
    {
        public static void AddSharpCss(this IServiceCollection services)
        {
            var processor = new ReflectionCssStyleProcessor();
            var service = new CssStyleService(processor);
            services.AddSingleton<ICssStyleService>(service);
            services.AddSingleton<ICssStyleEmitter>(service);
            services.AddSingleton<ICssStyleProcessor>(processor);
        }
    }
}
