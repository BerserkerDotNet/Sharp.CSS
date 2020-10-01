using Sharp.CSS.Types;
using System;

namespace Sharp.CSS.Extensions
{
    public static class CssUnitsExtentions
    {
        public static string ToCssString(this CssUnits unit)
        {
            if (unit == CssUnits.percentage)
            {
                return "%";
            }

            if (unit == CssUnits.@in)
            {
                return "in";
            }

            return Enum.GetName(typeof(CssUnits), unit);
        }
    }
}
