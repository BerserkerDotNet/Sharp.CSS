namespace Sharp.CSS.Types
{
    public class BorderImageWidth : BaseCssValue
    {
        public BorderImageWidth(string value)
            : base(value)
        {
        }

        public BorderImageWidth(Size size)
            : this($"{size}")
        {
        }

        public BorderImageWidth(Size topAndBottom, Size rightAndLeft)
            : this($"{topAndBottom} {rightAndLeft}")
        {
        }

        public BorderImageWidth(Size top, Size rightAndLeft, Size bottom)
            : this($"{top} {rightAndLeft} {bottom}")
        {
        }

        public BorderImageWidth(Size top, Size right, Size bottom, Size left)
            : this($"{top} {right} {bottom} {left}")
        {
        }

        public static implicit operator BorderImageWidth(string value) => new BorderImageWidth(value);
        public static implicit operator BorderImageWidth(Size size) => new BorderImageWidth(size);
        public static implicit operator BorderImageWidth(int size) => new BorderImageWidth(size);

        public static readonly BorderImageWidth Auto = new BorderImageWidth("auto");
        public static readonly BorderImageWidth Initial = new BorderImageWidth("initial");
        public static readonly BorderImageWidth Inherit = new BorderImageWidth("inherit");
    }
}
