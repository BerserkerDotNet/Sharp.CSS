namespace Sharp.CSS.Types
{
    public class BackgroundRepeat
    {
        private readonly string _value;

        public BackgroundRepeat(string value)
        {
            _value = value;
        }

        public override string ToString()
        {
            return _value;
        }

        public static implicit operator BackgroundRepeat(string value) => new BackgroundRepeat(value);

        public static readonly BackgroundRepeat Repeat = new BackgroundRepeat("repeat");
        public static readonly BackgroundRepeat RepeatX = new BackgroundRepeat("repeat-x");
        public static readonly BackgroundRepeat RepeatY = new BackgroundRepeat("repeat-y");
        public static readonly BackgroundRepeat NoRepeat = new BackgroundRepeat("no-repeat");
        public static readonly BackgroundRepeat Space = new BackgroundRepeat("space");
        public static readonly BackgroundRepeat Round = new BackgroundRepeat("round");
        public static readonly BackgroundRepeat Initial = new BackgroundRepeat("initial");
        public static readonly BackgroundRepeat Inherit = new BackgroundRepeat("inherit");
    }
}
