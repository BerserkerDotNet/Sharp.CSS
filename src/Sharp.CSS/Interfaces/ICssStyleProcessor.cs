using Sharp.CSS.CssStyleSets;

namespace Sharp.CSS.Interfaces
{
    public interface ICssStyleProcessor
    {
        string Process(string name, StyleSet set);
    }
}
