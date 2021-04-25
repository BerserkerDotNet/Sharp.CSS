namespace Sharp.CSS.Types
{
    public class BoxDecorationBreak : BaseCssValue
    {
        public BoxDecorationBreak(string value)
            : base(value)
        {
        }

        public static implicit operator BoxDecorationBreak(string value) => new(value);

        /// <summary>
        /// Default. Box decorations are applied to the element as a whole and break at the edges of the element fragments
        /// </summary>
        public static BoxDecorationBreak Slice = new BoxDecorationBreak("slice");

        /// <summary>
        /// Box decorations apply to each fragment of the element as if the fragments were individual elements. Borders wrap the four edges of each fragment of the element, and backgrounds are redrawn in full for each fragment
        /// </summary>
        public static BoxDecorationBreak Clone = new BoxDecorationBreak("clone");

        public static BoxDecorationBreak Initial = new BoxDecorationBreak("initial");
        public static BoxDecorationBreak Inherit = new BoxDecorationBreak("inherit");
    }
}
