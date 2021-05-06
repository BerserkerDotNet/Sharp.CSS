using Sharp.CSS.CssStyleSets;
using Sharp.CSS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

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

        public TResponse GetClassNames<TResponse>(object styleSets)
            where TResponse: class, new()
        {
            if (styleSets is null)
            {
                throw new ArgumentNullException(nameof(styleSets));
            }

            var responseInstance = new TResponse();
            var properties = styleSets.GetType()
                .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(p => p.PropertyType == typeof(StyleSet));

            foreach (var property in properties)
            {
                var className = GetClassName((StyleSet)property.GetValue(styleSets), property.Name.ToLower());
                responseInstance.GetType().GetProperty(property.Name).SetValue(responseInstance, className);
            }

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
