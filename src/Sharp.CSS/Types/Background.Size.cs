namespace Sharp.CSS.Types
{
    public class BackgroundSize
    {
        private readonly string _value;
        public BackgroundSize(Size width, Size hegiht)
        {
            _value = $"{width} {hegiht}";
        }

        protected BackgroundSize(string value)
        {
            _value = value;
        }

        public static implicit operator BackgroundSize(int value) => new BackgroundSize(value, "auto");
        public static implicit operator BackgroundSize(float value) => new BackgroundSize(value, "auto");
        public static implicit operator BackgroundSize(string value) => new BackgroundSize(value);

        public static BackgroundSize Auto = new BackgroundSize("auto");
        public static BackgroundSize Cover = new BackgroundSize("cover");
        public static BackgroundSize Contain = new BackgroundSize("contain");
        public static BackgroundSize Initial = new BackgroundSize("initial");
        public static BackgroundSize Inherit = new BackgroundSize("inherit");

        public override string ToString()
        {
            return _value;
        }
    }
}
