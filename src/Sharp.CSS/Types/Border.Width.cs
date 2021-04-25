namespace Sharp.CSS.Types
{
    public class BorderWidth : BaseCssValue
    {
        public BorderWidth(string value)
            : base(value)
        {
        }

        public BorderWidth(BorderSideWidth topAndBottom, BorderSideWidth rightAndLeft)
            : this($"{topAndBottom} {rightAndLeft}")
        {
        }

        public BorderWidth(BorderSideWidth top, BorderSideWidth rightAndLeft, BorderSideWidth bottom)
            : this($"{top} {rightAndLeft} {bottom}")
        {
        }

        public BorderWidth(BorderSideWidth top, BorderSideWidth right, BorderSideWidth bottom, BorderSideWidth left)
            : this($"{top} {right} {bottom} {left}")
        {
        }

        public static implicit operator BorderWidth(string value) => new BorderWidth(value);
        public static implicit operator BorderWidth(Size size) => new BorderWidth(size.ToString());
        public static implicit operator BorderWidth(int size) => new BorderWidth(new Size(size).ToString());

        public static readonly BorderWidth Medium = new BorderWidth("medium");
        public static readonly BorderWidth Thin = new BorderWidth("thin");
        public static readonly BorderWidth Thick = new BorderWidth("thick");
        public static readonly BorderWidth Initial = new BorderWidth("initial");
        public static readonly BorderWidth Inherit = new BorderWidth("inherit");
    }
}
