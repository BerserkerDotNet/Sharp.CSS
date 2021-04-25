namespace Sharp.CSS.Types
{
    public class BorderImageRepeat : BaseCssValue
    {
        public BorderImageRepeat(string value)
            : base(value)
        {
        }

        public BorderImageRepeat(BorderImageRepeat topBottom, BorderImageRepeat rightLeft)
            : this($"{topBottom} {rightLeft}")
        {
        }

        public static implicit operator BorderImageRepeat(string repeat) => new BorderImageRepeat(repeat);

        /// <summary>
        /// Default value. The image is stretched to fill the area
        /// </summary>
        public static readonly BorderImageRepeat Stretch = new BorderImageRepeat("stretch");

        /// <summary>
        /// The image is tiled (repeated) to fill the area
        /// </summary>
        public static readonly BorderImageRepeat Repeat = new BorderImageRepeat("repeat");

        /// <summary>
        /// The image is tiled (repeated) to fill the area. If it does not fill the area with a whole number of tiles, the image is rescaled so it fits
        /// </summary>
        public static readonly BorderImageRepeat Round = new BorderImageRepeat("round");

        /// <summary>
        /// The image is tiled (repeated) to fill the area. If it does not fill the area with a whole number of tiles, the extra space is distributed around the tiles
        /// </summary>
        public static readonly BorderImageRepeat Space = new BorderImageRepeat("space");

        public static readonly BorderImageRepeat Initial = new BorderImageRepeat("initial");
        public static readonly BorderImageRepeat Inherit = new BorderImageRepeat("inherit");
    }
}
