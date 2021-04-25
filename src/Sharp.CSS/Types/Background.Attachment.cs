namespace Sharp.CSS.Types
{
    public class BackgroundAttachment
    {
        private readonly string _value;

        public BackgroundAttachment(string value)
        {
            _value = value;
        }

        public override string ToString()
        {
            return _value;
        }

        public static implicit operator BackgroundAttachment(string value) => new BackgroundAttachment(value);

        public static readonly BackgroundAttachment Scroll = new BackgroundAttachment("scroll");
        public static readonly BackgroundAttachment Fixed = new BackgroundAttachment("fixed");
        public static readonly BackgroundAttachment Local = new BackgroundAttachment("local");
        public static readonly BackgroundAttachment Initial = new BackgroundAttachment("initial");
        public static readonly BackgroundAttachment Inherit = new BackgroundAttachment("inherit");
    }
}
