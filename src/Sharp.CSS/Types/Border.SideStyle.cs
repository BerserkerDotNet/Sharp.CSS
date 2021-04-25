namespace Sharp.CSS.Types
{
    public class BorderSideStyle : BaseCssValue
    {
        public BorderSideStyle(string value)
            : base(value)
        {
        }

        public static implicit operator BorderSideStyle(string value) => new BorderSideStyle(value);

        /// <summary>
        /// Default value. Specifies no border
        /// </summary>
        public static readonly BorderSideStyle None = new BorderSideStyle("none");

        /// <summary>
        /// The same as "none", except in border conflict resolution for table elements
        /// </summary>
        public static readonly BorderSideStyle Hidden = new BorderSideStyle("hidden");

        /// <summary>
        /// Specifies a dotted border
        /// </summary>
        public static readonly BorderSideStyle Dotted = new BorderSideStyle("dotted");

        /// <summary>
        /// Specifies a dashed border
        /// </summary>
        public static readonly BorderSideStyle Dashed = new BorderSideStyle("dashed");

        /// <summary>
        /// Specifies a solid border
        /// </summary>
        public static readonly BorderSideStyle Solid = new BorderSideStyle("solid");

        /// <summary>
        /// Specifies a double border
        /// </summary>
        public static readonly BorderSideStyle Double = new BorderSideStyle("double");

        /// <summary>
        /// Specifies a 3D grooved border. The effect depends on the border-color value
        /// </summary>
        public static readonly BorderSideStyle Groove = new BorderSideStyle("groove");

        /// <summary>
        /// Specifies a 3D ridged border. The effect depends on the border-color value
        /// </summary>
        public static readonly BorderSideStyle Ridge = new BorderSideStyle("ridge");

        /// <summary>
        /// Specifies a 3D inset border. The effect depends on the border-color value
        /// </summary>
        public static readonly BorderSideStyle Inset = new BorderSideStyle("inset");

        /// <summary>
        /// Specifies a 3D outset border. The effect depends on the border-color value
        /// </summary>
        public static readonly BorderSideStyle Outset = new BorderSideStyle("outset");

        public static readonly BorderSideStyle Initial = new BorderSideStyle("initial");
        public static readonly BorderSideStyle Inherit = new BorderSideStyle("inherit");
    }
}
