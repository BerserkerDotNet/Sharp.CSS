using Microsoft.AspNetCore.Components;
using Sharp.CSS.CssStyleSets;
using Sharp.CSS.Interfaces;
using Sharp.CSS.Types;
using Sharp.CSS.Types.Generated;

namespace Sharp.CSS.Samples.Pages
{
    public class GradientLoadingBase : ComponentBase
    {
        private GradientLoadingStyles _styles = new GradientLoadingStyles();

        [Inject]
        public ICssStyleService Css { get; set; }

        public GradientLoadingStyles Styles => _styles;

        protected override void OnInitialized()
        {
            _styles = GetCounterStyles();
        }

        private GradientLoadingStyles GetCounterStyles()
        {
            return Css.GetClassNames<GradientLoadingStyles>(new
            {
                Card = new StyleSet { Width = new (18, CssUnits.rem) },
                CardImage = new StyleSet { Width = 286, Height = 180, MarginBottom = 10 },
                CardHeader = new StyleSet { Width = 246, Height = 24, MarginBottom = 10 },
                CardText = new StyleSet { Width = 246, Height = 72, MarginBottom = 10 },
                CardButton = new StyleSet { Width = 132, Height = 38, MarginBottom = 10 },
                Gradient = new StyleSet
                {
                    Background = new (image: new LinearGradient("linear-gradient(to right, #eff1f3 4%, #e2e2e2 25%, #eff1f3 36%)")),
                    BackgroundSize = new (1000, new Size(100, CssUnits.percentage)),
                    BackgroundPosition = new (486, 0),
                    Position = "relative",
                    AnimationDuration = "2s",
                    AnimationFillMode = "forwards",
                    AnimationIterationCount = "infinite",
                    AnimationName = "placeHolderShimmer",
                    AnimationTimingFunction = "linear"
                }
            });
        }
    }
}
