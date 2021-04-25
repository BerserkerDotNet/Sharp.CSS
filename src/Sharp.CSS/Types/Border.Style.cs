namespace Sharp.CSS.Types
{
    public class BorderStyle : BaseCssValue
    {
        public BorderStyle(BorderSideStyle topAndBottom, BorderSideStyle rightAndLeft)
            : this($"{topAndBottom} {rightAndLeft}")
        {
        }

        public BorderStyle(BorderSideStyle top, BorderSideStyle rightAndLeft, BorderSideStyle bottom)
            : this($"{top} {rightAndLeft} {bottom}")
        {
        }

        public BorderStyle(BorderSideStyle top, BorderSideStyle right, BorderSideStyle bottom, BorderSideStyle left)
            : this($"{top} {right} {bottom} {left}")
        {
        }

        public BorderStyle(string value)
            : base(value)
        {
        }

        public static implicit operator BorderStyle(string value) => new BorderStyle(value);

        /// <summary>
        /// Default value. Specifies no border
        /// </summary>
        public static readonly BorderStyle None = new BorderStyle("none");

        /// <summary>
        /// The same as "none", except in border conflict resolution for table elements
        /// </summary>
        public static readonly BorderStyle Hidden = new BorderStyle("hidden");

        /// <summary>
        /// Specifies a dotted border
        /// </summary>
        public static readonly BorderStyle Dotted = new BorderStyle("dotted");

        /// <summary>
        /// Specifies a dashed border
        /// </summary>
        public static readonly BorderStyle Dashed = new BorderStyle("dashed");

        /// <summary>
        /// Specifies a solid border
        /// </summary>
        public static readonly BorderStyle Solid = new BorderStyle("solid");

        /// <summary>
        /// Specifies a double border
        /// </summary>
        public static readonly BorderStyle Double = new BorderStyle("double");

        /// <summary>
        /// Specifies a 3D grooved border. The effect depends on the border-color value
        /// </summary>
        public static readonly BorderStyle Groove = new BorderStyle("groove");

        /// <summary>
        /// Specifies a 3D ridged border. The effect depends on the border-color value
        /// </summary>
        public static readonly BorderStyle Ridge = new BorderStyle("ridge");

        /// <summary>
        /// Specifies a 3D inset border. The effect depends on the border-color value
        /// </summary>
        public static readonly BorderStyle Inset = new BorderStyle("inset");

        /// <summary>
        /// Specifies a 3D outset border. The effect depends on the border-color value
        /// </summary>
        public static readonly BorderStyle Outset = new BorderStyle("outset");

        public static readonly BorderStyle Initial = new BorderStyle("initial");
        public static readonly BorderStyle Inherit = new BorderStyle("inherit");
    }
}
