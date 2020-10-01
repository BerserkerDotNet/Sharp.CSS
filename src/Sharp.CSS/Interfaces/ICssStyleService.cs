using Sharp.CSS.CssStyleSets;

namespace Sharp.CSS.Interfaces
{
    public interface ICssStyleService
    {
        string GetClassName(StyleSet set, string prefix);

        TResponse GetClassNames<TStyleSets, TResponse>(TStyleSets styleSets)
            where TResponse : new();
    }
}
