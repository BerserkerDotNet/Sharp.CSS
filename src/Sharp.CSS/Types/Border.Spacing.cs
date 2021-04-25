namespace Sharp.CSS.Types
{
    public class BorderSpacing : BaseCssValue
    {
        public BorderSpacing(string value)
            : base(value)
        {
        }

        public BorderSpacing(Size value)
            : base(value.ToString())
        {
        }

        public BorderSpacing(Size horizontal, Size vertical)
            : base($"{horizontal} {vertical}")
        {
        }

        public static implicit operator BorderSpacing(int value) => new BorderSpacing(value);
        public static implicit operator BorderSpacing(float value) => new BorderSpacing(value);
        public static implicit operator BorderSpacing(Size value) => new BorderSpacing(value);
        public static implicit operator BorderSpacing(string value) => new BorderSpacing(value);

        public static readonly BorderSpacing Initial = new BorderSpacing("initial");
        public static readonly BorderSpacing Inherit = new BorderSpacing("inherit");
    }
}
