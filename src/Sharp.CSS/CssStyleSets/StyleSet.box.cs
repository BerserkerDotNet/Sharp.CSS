using Sharp.CSS.Types;

namespace Sharp.CSS.CssStyleSets
{
    public partial class StyleSet
    {
        /// <summary>
        /// Sets the behavior of the background and border of an element at page-break, or, for in-line elements, at line-break.
        /// </summary>
        public BoxDecorationBreak BoxDecorationBreak { get; set; }

        /// <summary>
        /// Attaches one or more shadows to an element
        /// </summary>
        public BoxShadow BoxShadow { get; set; }

        /// <summary>
        /// Defines how the width and height of an element are calculated: should they include padding and borders, or not
        /// </summary>
        public BoxSizing BoxSizing { get; set; }
    }
}
