namespace Sharp.CSS.Types
{
    public class Percentage : BaseCssValue
    {
        public Percentage(string value)
            : base(value)
        {
        }

        public Percentage(int value)
            : base($"{value}%")
        {
        }

        public Percentage(float value)
            : base($"{value}%")
        {
        }

        public static implicit operator Percentage(float value) => new Percentage(value);
        public static implicit operator Percentage(int value) => new Percentage(value);
        public static implicit operator Percentage(string value) => new Percentage(value);
    }
}
