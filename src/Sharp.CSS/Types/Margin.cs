namespace Sharp.CSS.Types
{
    public class Margin : BaseCssValue
    {
        public Margin(string value)
            : base(value)
        {
        }

        public Margin(Size value)
            : base(value.ToString())
        {
        }

        public Margin(Size topBottom, Size rightLeft)
            : base($"{topBottom} {rightLeft}")
        {
        }

        public Margin(Size top, Size rightLeft, Size bottom)
            : base($"{top} {rightLeft} {bottom}")
        {
        }

        public Margin(Size top, Size right, Size bottom, Size left)
            : base($"{top} {right} {bottom} {left}")
        {
        }

        public static implicit operator Margin(int value) => new Margin(value);
        public static implicit operator Margin(float value) => new Margin(value);
        public static implicit operator Margin(Size value) => new Margin(value);
        public static implicit operator Margin(string value) => new Margin(value);

        public static readonly Margin Auto = new Margin("auto");
        public static readonly Margin Initial = new Margin("initial");
        public static readonly Margin Inherit = new Margin("inherit");
    }
}
