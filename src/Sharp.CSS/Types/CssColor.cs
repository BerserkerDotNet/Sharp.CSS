using System.Drawing;

namespace Sharp.CSS.Types
{
    public class CssColor
    {
        private readonly string _colorHex;

        public CssColor(string colorHex)
        {
            _colorHex = colorHex;
        }


        public static implicit operator CssColor(Color c)
        {
            if (c.IsNamedColor)
            {
                return c.Name.ToLower();
            }

            return c.A == 255
                ? new CssColor($"#{c.R.ToString("X2")}{c.G.ToString("X2")}{c.B.ToString("X2")}")
                : new CssColor($"#{c.R.ToString("X2")}{c.G.ToString("X2")}{c.B.ToString("X2")}{c.A.ToString("X2")}");
        }

        public static implicit operator CssColor(string hex) => new CssColor(hex);

        public override string ToString()
        {
            return _colorHex;
        }
    }
}
