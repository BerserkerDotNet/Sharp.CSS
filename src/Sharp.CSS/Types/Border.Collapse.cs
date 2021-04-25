namespace Sharp.CSS.Types
{
    public class BorderCollapse : BaseCssValue
    {
        public BorderCollapse(string value)
            : base(value)
        {
        }

        public static implicit operator BorderCollapse(string value) => new BorderCollapse(value);

        public static readonly BorderCollapse Collapse = new BorderCollapse("collapse");
        public static readonly BorderCollapse Separate = new BorderCollapse("separate");
        public static readonly BorderCollapse Initial = new BorderCollapse("initial");
        public static readonly BorderCollapse Inherit = new BorderCollapse("inherit");
    }
}
