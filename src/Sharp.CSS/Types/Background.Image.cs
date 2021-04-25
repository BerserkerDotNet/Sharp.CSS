namespace Sharp.CSS.Types
{
    public class BackgroundImage
    {
        private readonly string _image;

        public BackgroundImage(string image)
        {
            _image = image;
        }

        public override string ToString()
        {
            return _image;
        }

        public static implicit operator BackgroundImage(Url url) => new BackgroundImage(url.ToString());
        public static implicit operator BackgroundImage(LinearGradient gradient) => new BackgroundImage(gradient.ToString());
        public static implicit operator BackgroundImage(RadialGradient gradient) => new BackgroundImage(gradient.ToString());
        public static implicit operator BackgroundImage(RepeatingGradient<LinearGradient> gradient) => new BackgroundImage(gradient.ToString());
        public static implicit operator BackgroundImage(RepeatingGradient<RadialGradient> gradient) => new BackgroundImage(gradient.ToString());
        public static implicit operator BackgroundImage(string image) => new BackgroundImage(image);

        public static BackgroundImage None = new BackgroundImage("none");
        public static BackgroundImage Initial = new BackgroundImage("initial");
        public static BackgroundImage Inherit = new BackgroundImage("inherit");
    }

    public class LinearGradient
    {
        private readonly int _degrees;
        private readonly CssColor[] _colors;

        public LinearGradient(int degrees, params CssColor[] colors)
        {
            this._degrees = degrees;
            this._colors = colors;
        }

        public LinearGradient(params CssColor[] colors)
            : this(0, colors)
        {
        }

        public override string ToString()
        {
            return $"linear-gradient({_degrees}deg, {string.Join(", ", (object[])_colors)})";
        }
    }

    public class RadialGradient
    {
        private readonly string _shape;
        private readonly CssColor[] _colors;

        public RadialGradient(string shape, params CssColor[] colors)
        {
            _shape = shape;
            _colors = colors;
        }

        public RadialGradient(params CssColor[] colors)
            : this("ellipse", colors)
        {
        }

        public override string ToString()
        {
            return $"radial-gradient({_shape}, {string.Join(", ", (object[])_colors)})";
        }
    }

    public class RepeatingGradient<T>
    {
        private readonly T _gradient;

        public RepeatingGradient(T gradient)
        {
            _gradient = gradient;
        }

        public override string ToString()
        {
            return $"repeating-{_gradient}";
        }
    }
}
