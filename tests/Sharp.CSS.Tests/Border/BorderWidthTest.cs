using FluentAssertions;
using NUnit.Framework;
using Sharp.CSS.Types;

namespace Sharp.CSS.Tests.Border
{
    [TestFixture]
    public class BorderWidthTests
    {
        [Test]
        public void StringValue()
        {
            new BorderWidth("foo bla").ToString().Should().Be("foo bla");
            BorderWidth.Thin.ToString().Should().Be("thin");
            BorderWidth.Medium.ToString().Should().Be("medium");
            BorderWidth.Thick.ToString().Should().Be("thick");
            BorderWidth.Inherit.ToString().Should().Be("inherit");
            BorderWidth.Initial.ToString().Should().Be("initial");
        }

        [Test]
        public void SingleValueRadius()
        {
            ((BorderWidth)new CssSize(34)).ToString().Should().Be("34px");
        }

        [Test]
        public void MultipleValuesRadius()
        {
            new BorderWidth(20, 10).ToString().Should().Be("20px 10px");
            new BorderWidth(20, 10, 5).ToString().Should().Be("20px 10px 5px");
            new BorderWidth(20, 10, 5, 2.5f).ToString().Should().Be("20px 10px 5px 2.5px");
        }
    }
}
