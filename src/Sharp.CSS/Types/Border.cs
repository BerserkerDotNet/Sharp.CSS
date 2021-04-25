namespace Sharp.CSS.Types
{
    public class Border : BaseCssValue
    {
        public Border(string value)
            : base(value)
        {
        }

        public Border(BorderSideStyle style)
            : base($"{style}")
        {
        }

        public Border(BorderSideStyle style, CssColor borderColor)
            : this($"{style} {borderColor}")
        {
        }

        public Border(BorderSideWidth width, BorderSideStyle style)
            : this($"{width} {style}")
        {
        }

        public Border(BorderSideWidth width, BorderSideStyle style, CssColor borderColor)
            :this($"{width} {style} {borderColor}")
        {
        }

        public static implicit operator Border(string value) => new Border(value);
        public static implicit operator Border(BorderSideStyle value) => new Border(value);

        public static readonly Border Initial = new Border("initial");
        public static readonly Border Inherit = new Border("inherit");
    }
}
