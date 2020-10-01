using Sharp.CSS.Extensions;

namespace Sharp.CSS.Types
{
    public class CssSize
    {
        private readonly string _value;

        public CssSize(int value, CssUnits unit = CssUnits.px)
            : this((float)value, unit)
        {
        }

        public CssSize(float value, CssUnits unit = CssUnits.px)
        {
            _value = $"{value}{unit.ToCssString()}";
        }

        protected CssSize(string value)
        {
            _value = value;
        }

        public static implicit operator CssSize(int value) => new CssSize(value);
        public static implicit operator CssSize(float value) => new CssSize(value);
        public static implicit operator CssSize(string value) => new CssSize(value);

        public override string ToString()
        {
            return _value;
        }

        public static CssSize None = new CssSize("none");
        public static CssSize Initial = new CssSize("initial");
        public static CssSize Inherit = new CssSize("inherit");
    }

    public class CssBackgroundSize : CssSize
    {
        public CssBackgroundSize(int value, CssUnits unit = CssUnits.px)
            : base(value, unit)
        {
        }

        public CssBackgroundSize(float value, CssUnits unit = CssUnits.px)
            : base(value, unit)
        {
        }

        protected CssBackgroundSize(string value)
            : base(value)
        {
        }

        public static implicit operator CssBackgroundSize(int value) => new CssBackgroundSize(value);
        public static implicit operator CssBackgroundSize(float value) => new CssBackgroundSize(value);
        public static implicit operator CssBackgroundSize(string value) => new CssBackgroundSize(value);

        public static CssSize Auto = new CssBackgroundSize("auto");
        public static CssSize Cover = new CssBackgroundSize("cover");
        public static CssSize Contain = new CssBackgroundSize("contain");
    }
}
