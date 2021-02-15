using System;
using System.Collections.Generic;

namespace Sharp.CSS.CssStyleSets
{
    public partial class StyleSet
    {
        public Dictionary<string, string> DynamicProperties { get; } = new Dictionary<string, string>();

        public StyleSet With(string key, string value)
        {
            DynamicProperties.Add(key, value);
            return this;
        }

        public StyleSet With<T>(string key, T value)
        {
            if (value is null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            this.With(key, value.ToString());
            return this;
        }
    }
}
