namespace Sharp.CSS.Types
{
    public class BorderSideRadius : BaseCssValue
    {
        public BorderSideRadius(string value)
            : base(value)
        {
        }

        public BorderSideRadius(Size size)
            : this($"{size}")
        {
        }

        public BorderSideRadius(Size size1, Size size2)
            : this($"{size1} {size2}".Trim())
        {
        }

        public static implicit operator BorderSideRadius(Size size) => new BorderSideRadius(size);
        public static implicit operator BorderSideRadius(string value) => new BorderSideRadius(value);

        public static readonly BorderSideRadius Initial = new BorderSideRadius("initial");
        public static readonly BorderSideRadius Inherit = new BorderSideRadius("inherit");
    }
}
