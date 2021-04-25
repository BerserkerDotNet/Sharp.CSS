using Sharp.CSS.Extensions;
using System.Drawing;

namespace Sharp.CSS.Types
{
    public class Size
    {
        private readonly string _value;

        public Size(int value, CssUnits unit = CssUnits.px)
            : this((float)value, unit)
        {
        }

        public Size(float value, CssUnits unit = CssUnits.px)
        {
            _value = $"{value}{unit.ToCssString()}";
        }

        protected Size(string value)
        {
            _value = value;
        }

        public static implicit operator Size(int value) => new Size(value);
        public static implicit operator Size(float value) => new Size(value);
        public static implicit operator Size(string value) => new Size(value);

        public override string ToString()
        {
            return _value;
        }

        public static Size None = new Size("none");
        public static Size Initial = new Size("initial");
        public static Size Inherit = new Size("inherit");
    }
}
