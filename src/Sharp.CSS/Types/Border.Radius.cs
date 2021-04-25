namespace Sharp.CSS.Types
{
    public class BorderRadius : BaseCssValue
    {
        public BorderRadius(string value)
            : base(value)
        {
        }
        
        public BorderRadius(CssSize radius)
            : this($"{radius}")
        {
        }

        public BorderRadius(CssSize topLeftAndBottomRight, CssSize topRightAndBottomleft)
            : this($"{topLeftAndBottomRight} {topRightAndBottomleft}")
        {
        }

        public BorderRadius(CssSize topLeft, CssSize topRightAndBottomLeft, CssSize bottomRight)
            : this($"{topLeft} {topRightAndBottomLeft} {bottomRight}")
        {
        }

        public BorderRadius(CssSize topLeft, CssSize topRight, CssSize bottomRight, CssSize bottomLeft)
            : this($"{topLeft} {topRight} {bottomRight} {bottomLeft}")
        {
        }

        public static BorderRadius operator /(BorderRadius value1, BorderRadius value2) => new BorderRadius($"{value1} / {value2}");
        public static implicit operator BorderRadius(CssSize value) => new BorderRadius(value);
        public static implicit operator BorderRadius(int value) => new BorderRadius(value);
        public static implicit operator BorderRadius(float value) => new BorderRadius(value);
        public static implicit operator BorderRadius(string value) => new BorderRadius(value);

        public static readonly BorderRadius Initial = new BorderRadius("initial");
        public static readonly BorderRadius Inherit = new BorderRadius("inherit");
    }
}
