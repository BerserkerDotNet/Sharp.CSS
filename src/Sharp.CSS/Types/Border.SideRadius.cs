namespace Sharp.CSS.Types
{
    public class BorderSideRadius : BaseCssValue
    {
        public BorderSideRadius(string value)
            : base(value)
        {
        }

        public BorderSideRadius(CssSize size)
            : this($"{size}")
        {
        }

        public BorderSideRadius(CssSize size1, CssSize size2)
            : this($"{size1} {size2}".Trim())
        {
        }

        public static implicit operator BorderSideRadius(CssSize size) => new BorderSideRadius(size);
        public static implicit operator BorderSideRadius(string value) => new BorderSideRadius(value);

        public static readonly BorderSideRadius Initial = new BorderSideRadius("initial");
        public static readonly BorderSideRadius Inherit = new BorderSideRadius("inherit");
    }
}
