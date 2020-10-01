using Sharp.CSS.CssStyleSets;
using Sharp.CSS.Interfaces;

namespace Sharp.CSS.Services
{
    /*
     * How to read properties
     * Approach 1:
     *  - use reflection to get all properties
     *  - use source generators to generate properties from the interface that will add properties to the dictionary
     *  - manually add objects to the dictionary
     */
    public class CssStyleService : ICssStyleService
    {
        private static int _counter = 0;

        public string GetClassName(StyleSet set, string prefix = "cssStyle")
        {
            var cssClassName = $"{prefix}-{_counter++}";
            return cssClassName;
        }

        public TResponse GetClassNames<TStyleSets, TResponse>(TStyleSets styleSets)
            where TResponse: new()
        {
            var responseInstance = new TResponse();

            return responseInstance;
        }
    }
}
