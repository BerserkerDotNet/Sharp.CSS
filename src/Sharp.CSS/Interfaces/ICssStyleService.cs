using Sharp.CSS.CssStyleSets;

namespace Sharp.CSS.Interfaces
{
    public interface ICssStyleService
    {
        string GetClassName(StyleSet set, string prefix = "cssStyle");

        TResponse GetClassNames<TStyleSets, TResponse>(TStyleSets styleSets)
            where TResponse : new();
    }

    public interface ICssStyleEmitter
    {
        void RegisterListener(ICssStyleEmitListener listener);

        void RemoveListener(ICssStyleEmitListener listener);
    }

    public interface ICssStyleEmitListener
    {
        void OnCssEmitted(string cssContent);
    }
}
