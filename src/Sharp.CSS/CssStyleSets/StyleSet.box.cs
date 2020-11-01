using System;
using System.Collections.Generic;
using System.Text;

namespace Sharp.CSS.CssStyleSets
{
    public partial class StyleSet
    {
        /// <summary>
        /// Sets the behavior of the background and border of an element at page-break, or, for in-line elements, at line-break.
        /// </summary>
        public string BoxDecorationBreak { get; set; }

        /// <summary>
        /// Attaches one or more shadows to an element
        /// </summary>
        public string BoxShadow { get; set; }

        /// <summary>
        /// Defines how the width and height of an element are calculated: should they include padding and borders, or not
        /// </summary>
        public string BoxSizing { get; set; }
    }
}
