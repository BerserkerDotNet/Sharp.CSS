using Sharp.CSS.Extensions;

namespace Sharp.CSS.Types
{
    public class BackgroundPosition
    {
        private readonly string _value;

        public BackgroundPosition(float x, float y, CssUnits units)
        {
            var unit = units.ToCssString();
            _value = $"{x}{unit} {y}{unit}";
        }

        public BackgroundPosition(string value)
        {
            _value = value;
        }

        public static implicit operator BackgroundPosition(string value) => new BackgroundPosition(value);

        public override string ToString()
        {
            return _value;
        }

        public static readonly BackgroundPosition LeftTop = new BackgroundPosition("left top");
        public static readonly BackgroundPosition LeftCenter = new BackgroundPosition("left center");
        public static readonly BackgroundPosition LeftBottom = new BackgroundPosition("left bottom");
        public static readonly BackgroundPosition RightTop = new BackgroundPosition("right top");
        public static readonly BackgroundPosition RightCenter = new BackgroundPosition("right center");
        public static readonly BackgroundPosition RightBottom = new BackgroundPosition("right bottom");
        public static readonly BackgroundPosition CenterTop = new BackgroundPosition("center top");
        public static readonly BackgroundPosition CenterCenter = new BackgroundPosition("center center");
        public static readonly BackgroundPosition CenterBottom = new BackgroundPosition("center bottom");
    }
}
