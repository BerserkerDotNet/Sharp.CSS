namespace Sharp.CSS.Types
{
    public class BorderImageSlice : BaseCssValue
    {
        public BorderImageSlice(string value)
            : base(value)
        {
        }

        public BorderImageSlice(Value size)
            : base(size.ToString())
        {
        }

        public BorderImageSlice(Value topBottom, Value rigthLeft)
            : base($"{topBottom} {rigthLeft}")
        {
        }

        public BorderImageSlice(Value top, Value rigthLeft, Value bottom)
            : base($"{top} {rigthLeft} {bottom}")
        {
        }

        public BorderImageSlice(Value top, Value rigth, Value bottom, Value left)
            : base($"{top} {rigth} {bottom} {left}")
        {
        }

        public static implicit operator BorderImageSlice(float multiple) => new BorderImageSlice(multiple);
        public static implicit operator BorderImageSlice(int multiple) => new BorderImageSlice(multiple);
        public static implicit operator BorderImageSlice(Value value) => new BorderImageSlice(value);
        public static implicit operator BorderImageSlice(Percentage value) => new BorderImageSlice(value);
        public static implicit operator BorderImageSlice(string value) => new BorderImageSlice(value);

        public static readonly BorderImageSlice Fill = new BorderImageSlice("fill");
        public static readonly BorderImageSlice Initial = new BorderImageSlice("initial");
        public static readonly BorderImageSlice Inherit = new BorderImageSlice("inherit");

        public class Value : BaseCssValue
        {
            public Value(string value)
                : base(value)
            {
            }

            public Value(int value)
                : base(value.ToString())
            {
            }

            public Value(float value)
                : base(value.ToString())
            {
            }

            public Value(Percentage value)
                : base(value.ToString())
            {
            }

            public static implicit operator Value(float value) => new Value(value);
            public static implicit operator Value(int value) => new Value(value);
            public static implicit operator Value(Percentage value) => new Value(value);
            public static implicit operator Value(string value) => new Value(value);
        }
    }
}
