namespace Sharp.CSS.Types
{
    public class Sizing
    {
        private readonly string _value;

        public Sizing(string value)
        {
            _value = value;
        }

        public override string ToString()
        {
            return _value;
        }

        public static implicit operator Sizing(string value) => new Sizing(value);

        public static readonly Sizing PaddingBox = new Sizing("padding-box");
        public static readonly Sizing BorderBox = new Sizing("border-box");
        public static readonly Sizing ContentBox = new Sizing("content-box");
        public static readonly Sizing Initial = new Sizing("initial");
        public static readonly Sizing Inherit = new Sizing("inherit");
    }
}
