namespace Sharp.CSS.Types
{
    public class BorderImageOutset : BaseCssValue
    {
        public BorderImageOutset(string value)
            : base(value)
        {
        }

        public BorderImageOutset(Value size)
            : base(size.ToString())
        {
        }

        public BorderImageOutset(Value topBottom, Value rigthLeft)
            : base($"{topBottom} {rigthLeft}")
        {
        }

        public BorderImageOutset(Value top, Value rigthLeft, Value bottom)
            : base($"{top} {rigthLeft} {bottom}")
        {
        }

        public BorderImageOutset(Value top, Value rigth, Value bottom, Value left)
            : base($"{top} {rigth} {bottom} {left}")
        {
        }

        public static implicit operator BorderImageOutset(float multiple) => new BorderImageOutset(multiple);
        public static implicit operator BorderImageOutset(int multiple) => new BorderImageOutset(multiple);
        public static implicit operator BorderImageOutset(Size size) => new BorderImageOutset(size);
        public static implicit operator BorderImageOutset(Value value) => new BorderImageOutset(value);
        public static implicit operator BorderImageOutset(string value) => new BorderImageOutset(value);

        public static readonly BorderImageOutset Initial = new BorderImageOutset("initial");
        public static readonly BorderImageOutset Inherit = new BorderImageOutset("inherit");

        public class Value : BaseCssValue
        {
            public Value(string value)
                : base(value)
            {
            }

            public Value(Size size)
                : base(size.ToString())
            {
            }

            public Value(int size)
                : base(size.ToString())
            {
            }

            public Value(float size)
                : base(size.ToString())
            {
            }

            public static implicit operator Value(float multiple) => new Value(multiple);
            public static implicit operator Value(int multiple) => new Value(multiple);
            public static implicit operator Value(Size size) => new Value(size);
            public static implicit operator Value(string value) => new Value(value);
        }
    }
}
