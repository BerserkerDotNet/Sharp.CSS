namespace Sharp.CSS.Types
{
    public class BorderImageWidth : BaseCssValue
    {
        public BorderImageWidth(string value)
            : base(value)
        {
        }

        public BorderImageWidth(CssSize size)
            : this($"{size}")
        {
        }

        public BorderImageWidth(CssSize topAndBottom, CssSize rightAndLeft)
            : this($"{topAndBottom} {rightAndLeft}")
        {
        }

        public BorderImageWidth(CssSize top, CssSize rightAndLeft, CssSize bottom)
            : this($"{top} {rightAndLeft} {bottom}")
        {
        }

        public BorderImageWidth(CssSize top, CssSize right, CssSize bottom, CssSize left)
            : this($"{top} {right} {bottom} {left}")
        {
        }

        public static implicit operator BorderImageWidth(string value) => new BorderImageWidth(value);
        public static implicit operator BorderImageWidth(CssSize size) => new BorderImageWidth(size);
        public static implicit operator BorderImageWidth(int size) => new BorderImageWidth(size);

        public static readonly BorderImageWidth Auto = new BorderImageWidth("auto");
        public static readonly BorderImageWidth Initial = new BorderImageWidth("initial");
        public static readonly BorderImageWidth Inherit = new BorderImageWidth("inherit");
    }
}
