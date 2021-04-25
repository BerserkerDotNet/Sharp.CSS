namespace Sharp.CSS.Types
{
    public class Display
    {
        private readonly string _value;

        public Display(string value)
        {
            _value = value;
        }
        
        public override string ToString()
        {
            return _value;
        }

        public static implicit operator Display(string value) => new Display(value);

        /// <summary>
        /// Displays an element as an inline element (like <span>). Any height and width properties will have no effect
        /// </summary>
        public static readonly Display Inline = new Display("inline");

        /// <summary>
        /// Displays an element as a block element (like <p>). It starts on a new line, and takes up the whole width
        /// </summary>
        public static readonly Display Block = new Display("block");

        /// <summary>
        /// Makes the container disappear, making the child elements children of the element the next level up in the DOM
        /// </summary>
        public static readonly Display Contents = new Display("contents");

        /// <summary>
        /// Displays an element as a block-level flex container
        /// </summary>
        public static readonly Display Flex = new Display("flex");

        /// <summary>
        /// Displays an element as a block-level grid container
        /// </summary>
        public static readonly Display Grid = new Display("grid");

        /// <summary>
        /// Displays an element as an inline-level block container. The element itself is formatted as an inline element, but you can apply height and width values
        /// </summary>
        public static readonly Display InlineBlock = new Display("inline-block");

        /// <summary>
        /// Displays an element as an inline-level flex container
        /// </summary>
        public static readonly Display InlineFlex = new Display("inline-flex");

        /// <summary>
        /// Displays an element as an inline-level grid container
        /// </summary>
        public static readonly Display InlineGrid = new Display("inline-grid");

        /// <summary>
        /// The element is displayed as an inline-level table
        /// </summary>
        public static readonly Display InlineTable = new Display("inline-table");

        /// <summary>
        /// Let the element behave like a <li> element
        /// </summary>
        public static readonly Display ListItem = new Display("list-item");

        /// <summary>
        /// Displays an element as either block or inline, depending on context
        /// </summary>
        public static readonly Display RunIn = new Display("run-in");

        /// <summary>
        /// Let the element behave like a <table> element
        /// </summary>
        public static readonly Display Table = new Display("table");

        /// <summary>
        /// Let the element behave like a <caption> element
        /// </summary>
        public static readonly Display TableCaption = new Display("table-caption");

        /// <summary>
        /// Let the element behave like a <colgroup> element
        /// </summary>
        public static readonly Display TableColumnGroup = new Display("table-column-group");

        /// <summary>
        /// Let the element behave like a <thead> element
        /// </summary>
        public static readonly Display TableHeaderGroup = new Display("table-header-group");

        /// <summary>
        /// Let the element behave like a <tfoot> element
        /// </summary>
        public static readonly Display TableFooterGroup = new Display("table-footer-group");

        /// <summary>
        /// Let the element behave like a <tbody> element
        /// </summary>
        public static readonly Display TableRowGroup = new Display("table-row-group");

        /// <summary>
        /// Let the element behave like a <td> element
        /// </summary>
        public static readonly Display TableCell = new Display("table-cell");

        /// <summary>
        /// Let the element behave like a <col> element
        /// </summary>
        public static readonly Display TableColumn = new Display("table-column");

        /// <summary>
        /// Let the element behave like a <tr> element
        /// </summary>
        public static readonly Display TableRow = new Display("table-row");

        /// <summary>
        /// The element is completely removed
        /// </summary>
        public static readonly Display None = new Display("none");

        /// <summary>
        /// Sets this property to its default value.
        /// </summary>
        public static readonly Display Initial = new Display("initial");

        /// <summary>
        /// Inherits this property from its parent element
        /// </summary>
        public static readonly Display Inherit = new Display("inherit");
    }
}
