using Sharp.CSS.CssStyleSets;
using Sharp.CSS.Interfaces;
using System.Collections.Generic;

namespace Sharp.CSS.Services
{
    public class CssStyleService : ICssStyleService, ICssStyleEmitter
    {
        private Dictionary<string,Css> _cssCache = new Dictionary<string, Css>();
        private List<ICssStyleEmitListener> _listeners = new List<ICssStyleEmitListener>();
        private readonly ICssStyleProcessor _processor;

        public CssStyleService(ICssStyleProcessor processor)
        {
            _processor = processor;
        }

        public string GetClassName(StyleSet set, string prefix = "cssStyle")
        {
            var cssContent = _processor.Process(set);
            var (isChanged, newClassName) = EnsureUniqueName(prefix, cssContent);

            if (isChanged)
            {
                NotiifyListeners(_processor.WrapInClassSelector(newClassName, cssContent));
            }

            return newClassName;
        }

        public TResponse GetClassNames<TStyleSets, TResponse>(TStyleSets styleSets)
            where TResponse: new()
        {
            var responseInstance = new TResponse();

            return responseInstance;
        }

        public void RegisterListener(ICssStyleEmitListener listener)
        {
            _listeners.Add(listener);
        }

        public void RemoveListener(ICssStyleEmitListener listener)
        {
            _listeners.Remove(listener);
        }

        private (bool, string) EnsureUniqueName(string prefix, string newCssContent)
        {
            var key = prefix.ToLower();
            if (!_cssCache.ContainsKey(key))
            {
                _cssCache.Add(key, new Css { CssContent = newCssContent, CounterValue = 1 });
                return (true, $"{prefix}-0");
            }

            var currentIndex = _cssCache[key].CounterValue++;
            
            //TODO: right now we generate newCSS all the time var isChanged = !string.Equals(_cssCache[key].CssContent, newCssContent, System.StringComparison.OrdinalIgnoreCase);

            return (true, $"{prefix}-{currentIndex}");
        }

        private void NotiifyListeners(string cssContent)
        {
            foreach (var listener in _listeners)
            {
                listener.OnCssEmitted(cssContent);
            }
        }

        private class Css
        {
            public string CssContent { get; set; }

            public int CounterValue { get; set; }
        }
    }
}
