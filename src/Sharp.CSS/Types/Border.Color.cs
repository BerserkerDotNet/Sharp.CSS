using System.Drawing;

namespace Sharp.CSS.Types
{
    public class BorderColor : BaseCssValue
    {
        public BorderColor(string value)
            : base(value)
        {
        }

        public BorderColor(CssColor color)
            : this($"{color}")
        {
        }

        public BorderColor(CssColor topAndBottom, CssColor rightAndLeft)
            : this($"{topAndBottom} {rightAndLeft}")
        {
        }

        public BorderColor(CssColor top, CssColor rightAndLeft, CssColor bottom)
            : this($"{top} {rightAndLeft} {bottom}")
        {
        }

        public BorderColor(CssColor top, CssColor right, CssColor bottom, CssColor left)
            : this($"{top} {right} {bottom} {left}")
        {
        }

        public static implicit operator BorderColor(string value) => new BorderColor(value);
        public static implicit operator BorderColor(CssColor color) => new BorderColor(color);
        public static implicit operator BorderColor(Color color) => new BorderColor(color);

        public static readonly BorderWidth Initial = new BorderWidth("initial");
        public static readonly BorderWidth Inherit = new BorderWidth("inherit");
    }
}
