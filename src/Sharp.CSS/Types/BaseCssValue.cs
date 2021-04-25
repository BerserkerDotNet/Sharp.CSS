using System;

namespace Sharp.CSS.Types
{
    public abstract class BaseCssValue : IEquatable<BaseCssValue>
    {
        private readonly string _value;

        public BaseCssValue(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(nameof(value), "Value can't be null.");
            }

            _value = value;
        }

        public override string ToString()
        {
            return _value;
        }

        public bool Equals(BaseCssValue other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return string.Equals(_value, other._value, StringComparison.Ordinal);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as BaseCssValue);
        }

        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }
    }
}
