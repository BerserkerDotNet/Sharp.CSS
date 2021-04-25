namespace Sharp.CSS.Types
{
    public class BoxSizing : BaseCssValue
    {
        public BoxSizing(string value)
            : base(value)
        {
        }

        public static implicit operator BoxSizing(string value) => new(value);

        /// <summary>
        /// Default. The width and height properties (and min/max properties) includes only the content. Border and padding are not included
        /// </summary>
        public static BoxSizing ContentBox = new BoxSizing("content-box");

        /// <summary>
        /// The width and height properties (and min/max properties) includes content, padding and border
        /// </summary>
        public static BoxSizing BorderBox = new BoxSizing("border-box");

        public static BoxSizing Initial = new BoxSizing("initial");
        public static BoxSizing Inherit = new BoxSizing("inherit");
    }
}
