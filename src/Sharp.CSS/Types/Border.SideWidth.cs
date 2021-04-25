namespace Sharp.CSS.Types
{
    public class BorderSideWidth : BaseCssValue
    {
        public BorderSideWidth(string value)
            : base(value)
        {
        }

        public static implicit operator BorderSideWidth(string value) => new BorderSideWidth(value);
        public static implicit operator BorderSideWidth(Size size) => new BorderSideWidth(size.ToString());
        public static implicit operator BorderSideWidth(int size) => new BorderSideWidth(new Size(size).ToString());
        public static implicit operator BorderSideWidth(float size) => new BorderSideWidth(new Size(size).ToString());

        public static readonly BorderSideWidth Medium = new BorderSideWidth("medium");
        public static readonly BorderSideWidth Thin = new BorderSideWidth("thin");
        public static readonly BorderSideWidth Thick = new BorderSideWidth("thick");
        public static readonly BorderSideWidth Initial = new BorderSideWidth("initial");
        public static readonly BorderSideWidth Inherit = new BorderSideWidth("inherit");
    }
}
