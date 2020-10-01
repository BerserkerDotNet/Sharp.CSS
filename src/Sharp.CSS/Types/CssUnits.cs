namespace Sharp.CSS.Types
{
    public enum CssUnits
    {
        /// <summary>
        /// Pixels (1px = 1/96th of 1in)
        /// </summary>
        px,
        /// <summary>
        /// Points (1pt = 1/72 of 1in)
        /// </summary>
        pt,
        /// <summary>
        /// Picas (1pc = 12 pt)
        /// </summary>
        pc,
        /// <summary>
        /// Inches (1in = 96px = 2.54cm)
        /// </summary>
        @in,
        /// <summary>
        /// Millimeters
        /// </summary>
        mm,
        /// <summary>
        /// Centimeters
        /// </summary>
        cm,
        /// <summary>
        /// Relative to the font-size of the element (2em means 2 times the size of the current font)
        /// </summary>
        em,
        /// <summary>
        /// Relative to the x-height of the current font (rarely used)
        /// </summary>
        ex,
        /// <summary>
        /// Relative to the width of the "0" (zero)
        /// </summary>
        ch,
        /// <summary>
        /// Relative to font-size of the root element
        /// </summary>
        rem,
        /// <summary>
        /// Relative to 1% of the width of the viewport
        /// </summary>
        vm,
        /// <summary>
        /// Relative to 1% of the height of the viewport
        /// </summary>
        vh,
        /// <summary>
        /// Relative to 1% of viewport's* smaller dimension
        /// </summary>
        vmin,
        /// <summary>
        /// Relative to 1% of viewport's* larger dimension
        /// </summary>
        vmax,
        /// <summary>
        /// Relative to the parent element
        /// </summary>
        percentage
    }
}
