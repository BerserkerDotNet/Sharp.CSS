using Sharp.CSS.Types;

namespace Sharp.CSS.CssStyleSets
{
    public partial class StyleSet
    {
        public Background Background { get; set; }
        public CssColor BackgroundColor { get; set; }
        public BackgroundImage BackgroundImage { get; set; }
        public BackgroundPosition BackgroundPosition { get; set; }
        public BackgroundSize BackgroundSize { get; set; }
        public BackgroundRepeat BackgroundRepeat { get; set; }
        public Sizing BackgroundOrigin { get; set; }
        public Sizing BackgroundClip { get; set; }
        public BackgroundAttachment BackgroundAttachment { get; set; }
    }
}
