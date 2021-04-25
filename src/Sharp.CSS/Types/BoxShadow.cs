namespace Sharp.CSS.Types
{
    public class BoxShadow : BaseCssValue
    {
        public BoxShadow(string value)
            : base(value)
        {
        }

        public BoxShadow(Size hOffset, Size vOffset, bool inset = false)
            : this($"{hOffset} {vOffset} {GetInsetValue(inset)}")
        {
        }

        public BoxShadow(Size hOffset, Size vOffset, CssColor color, bool inset = false)
            : this($"{hOffset} {vOffset} {color} {GetInsetValue(inset)}")
        {
        }

        public BoxShadow(Size hOffset, Size vOffset, Size blur, bool inset = false)
            : this($"{hOffset} {vOffset} {blur} {GetInsetValue(inset)}")
        {
        }

        public BoxShadow(Size hOffset, Size vOffset, Size blur, CssColor color, bool inset = false)
            : this($"{hOffset} {vOffset} {blur} {color} {GetInsetValue(inset)}")
        {
        }

        public BoxShadow(Size hOffset, Size vOffset, Size blur, Size spread, bool inset = false)
            : this($"{hOffset} {vOffset} {blur} {spread} {GetInsetValue(inset)}")
        {
        }

        public BoxShadow(Size hOffset, Size vOffset, Size blur, Size spread, CssColor color, bool inset = false)
            : this($"{hOffset} {vOffset} {blur} {spread} {color} {GetInsetValue(inset)}")
        {
        }

        private static string GetInsetValue(bool inset) => inset ? "inset" : string.Empty;

        public static BoxShadow operator +(BoxShadow shadow1, BoxShadow shadow2) => new BoxShadow($"{shadow1}, {shadow2}");
        public static implicit operator BoxShadow(string value) => new (value);

        public static BoxShadow None = new BoxShadow("none");
        public static BoxShadow Initial = new BoxShadow("initial");
        public static BoxShadow Inherit = new BoxShadow("inherit");
    }
}
