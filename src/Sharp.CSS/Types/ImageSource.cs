namespace Sharp.CSS.Types
{
    public class ImageSource : BaseCssValue
    {
        public ImageSource(string value)
            : base(value)
        {
        }

        public ImageSource(Url url)
            : base(url.ToString())
        {
        }

        public static implicit operator ImageSource(Url url) => new ImageSource(url);
        public static implicit operator ImageSource(string image) => new ImageSource(image);
        public static implicit operator ImageSource(LinearGradient gradient) => new ImageSource(gradient.ToString());
        public static implicit operator ImageSource(RadialGradient gradient) => new ImageSource(gradient.ToString());
        public static implicit operator ImageSource(RepeatingGradient<LinearGradient> gradient) => new ImageSource(gradient.ToString());
        public static implicit operator ImageSource(RepeatingGradient<RadialGradient> gradient) => new ImageSource(gradient.ToString());

        public static readonly ImageSource None = new ImageSource("none");
        public static readonly ImageSource Initial = new ImageSource("initial");
        public static readonly ImageSource Inherit = new ImageSource("inherit");
    }
}
