using Sharp.CSS.Blazor;
using Sharp.CSS.CssStyleSets;
using Sharp.CSS.Types;
using Sharp.CSS.Types.Generated;
using System.Drawing;

namespace Sharp.CSS.Samples.Pages
{
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
                },
                Extra = new StyleSet { }
            });
        }
    }
}
