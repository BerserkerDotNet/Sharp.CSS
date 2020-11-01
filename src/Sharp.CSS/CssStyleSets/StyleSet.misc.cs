using Sharp.CSS.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sharp.CSS.CssStyleSets
{
    public partial class StyleSet
    {
        public string Display { get; set; }

        public string Direction { get; set; }

        public CssColor Color { get; set; }

        /// <summary>
        /// Resets all properties (except unicode-bidi and direction)
        /// </summary>
        public string All { get; set; }

        public string Cursor { get; set; }

        public string Content { get; set; }

        public string CounterIncrement { get; set; }

        public string CounterReset { get; set; }

        public string Filter { get; set; }

        public string HangingPunctuation { get; set; }

        public string Hyphens { get; set; }

        public string Isolation { get; set; }

        public string Opacity { get; set; }

        public string PointerEvents { get; set; }

        public string Quotes { get; set; }

        public string ScrollBehavior { get; set; }

        public string Visibility { get; set; }

        public string ZIndex { get; set; }
    }
}
