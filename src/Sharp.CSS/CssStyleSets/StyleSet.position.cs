using Sharp.CSS.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sharp.CSS.CssStyleSets
{
    public partial class StyleSet
    {
        public string Position { get; set; }
        public CssSize Top { get; set; }
        public CssSize Bottom { get; set; }
        public CssSize Left { get; set; }
        public CssSize Right { get; set; }
        public string Float { get; set; }
        public string Clear { get; set; }
    }
}
