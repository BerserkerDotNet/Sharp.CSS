using Microsoft.AspNetCore.Components;
using Sharp.CSS.CssStyleSets;
using Sharp.CSS.Interfaces;
using Sharp.CSS.Types;
using Sharp.CSS.Types.Generated;
using System.Drawing;

namespace Sharp.CSS.Samples.Pages
{
    public class CounterBase : ComponentBase
    {
        [Inject]
        public ICssStyleService Css { get; set; }

        public CounterStyles Styles { get; set; }

        protected override void OnInitialized()
        {
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
        }
    }
}
