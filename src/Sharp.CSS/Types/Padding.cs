namespace Sharp.CSS.Types
{
    public class Padding : BaseCssValue
    {
        public Padding(string value)
            : base(value)
        {
        }

        public Padding(Size value)
            : base(value.ToString())
        {
        }

        public Padding(Size topBottom, Size rightLeft)
            : base($"{topBottom} {rightLeft}")
        {
        }

        public Padding(Size top, Size rightLeft, Size bottom)
            : base($"{top} {rightLeft} {bottom}")
        {
        }

        public Padding(Size top, Size right, Size bottom, Size left)
            : base($"{top} {right} {bottom} {left}")
        {
        }

        public static implicit operator Padding(int value) => new Padding(value);
        public static implicit operator Padding(float value) => new Padding(value);
        public static implicit operator Padding(Size value) => new Padding(value);
        public static implicit operator Padding(string value) => new Padding(value);

        public static readonly Padding Initial = new Padding("initial");
        public static readonly Padding Inherit = new Padding("inherit");
    }
}
