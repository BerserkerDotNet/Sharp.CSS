namespace Sharp.CSS.Types
{
    public class BorderRadius : BaseCssValue
    {
        public BorderRadius(string value)
            : base(value)
        {
        }
        
        public BorderRadius(Size radius)
            : this($"{radius}")
        {
        }

        public BorderRadius(Size topLeftAndBottomRight, Size topRightAndBottomleft)
            : this($"{topLeftAndBottomRight} {topRightAndBottomleft}")
        {
        }

        public BorderRadius(Size topLeft, Size topRightAndBottomLeft, Size bottomRight)
            : this($"{topLeft} {topRightAndBottomLeft} {bottomRight}")
        {
        }

        public BorderRadius(Size topLeft, Size topRight, Size bottomRight, Size bottomLeft)
            : this($"{topLeft} {topRight} {bottomRight} {bottomLeft}")
        {
        }

        public static BorderRadius operator /(BorderRadius value1, BorderRadius value2) => new BorderRadius($"{value1} / {value2}");
        public static implicit operator BorderRadius(Size value) => new BorderRadius(value);
        public static implicit operator BorderRadius(int value) => new BorderRadius(value);
        public static implicit operator BorderRadius(float value) => new BorderRadius(value);
        public static implicit operator BorderRadius(string value) => new BorderRadius(value);

        public static readonly BorderRadius Initial = new BorderRadius("initial");
        public static readonly BorderRadius Inherit = new BorderRadius("inherit");
    }
}
