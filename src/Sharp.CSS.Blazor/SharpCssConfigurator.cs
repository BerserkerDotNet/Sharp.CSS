using Microsoft.Extensions.DependencyInjection;
using Sharp.CSS.Interfaces;

namespace Sharp.CSS.Blazor
{
    public class SharpCssConfigurator
    {
        private readonly IServiceCollection _services;

        public SharpCssConfigurator(IServiceCollection services)
        {
            _services = services;
        }

        public void RegisterStyles<T>(object styles)
            where T: class, new()
        {
            _services.AddScoped<T>(s => s.GetService<ICssStyleService>().GetClassNames<T>(styles));
        }

        public void RegisterStylesModule(IStylesModule module)
        {
            module.Configure(this);
        }
    }
}
