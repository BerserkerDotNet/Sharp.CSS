using System.Text;

namespace Sharp.CSS.Types
{
    public class Background
    {
        private readonly string _value;

        public Background(string value)
        {
            _value = value;
        }

        public Background(
            CssColor color = null,
            BackgroundImage image = null,
            BackgroundPosition position = null,
            BackgroundSize size = null,
            BackgroundRepeat repeat = null,
            Sizing origin = null,
            Sizing clip = null,
            BackgroundAttachment attachment = null)
        {
            var builder = new StringBuilder();

            AppendParameter(builder, color);
            AppendParameter(builder, image);
            AppendParameter(builder, position);
            AppendConditionalParameter(builder, size, position);
            AppendParameter(builder, repeat);
            AppendParameter(builder, origin);
            AppendParameter(builder, clip);
            AppendParameter(builder, attachment);

            _value = builder.ToString().Trim();
        }

        public static implicit operator Background(string value) => new Background(value);

        public static readonly Background Initial = new Background("initial");
        public static readonly Background Inherit = new Background("inherit");

        public override string ToString()
        {
            return _value;
        }

        private void AppendParameter(StringBuilder builder, object parameter)
        {
            if (parameter is object)
            {
                builder.Append(parameter);
                builder.Append(" ");
            }
        }

        private void AppendConditionalParameter(StringBuilder builder, object parameter, object predecessor)
        {
            if (predecessor is object && parameter is object)
            {
                builder.Append("/ ");
                builder.Append(parameter);
                builder.Append(" ");
            }
        }
    }
}
