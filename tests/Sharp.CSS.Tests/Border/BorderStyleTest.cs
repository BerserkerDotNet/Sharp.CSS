using FluentAssertions;
using NUnit.Framework;
using Sharp.CSS.Types;
using static Sharp.CSS.Types.BorderSideStyle;

namespace Sharp.CSS.Tests.Border
{
    [TestFixture]
    public class BorderStyleTest
    {
        [Test]
        public void StringValue()
        {
            new BorderStyle("foo bla").ToString().Should().Be("foo bla");
            BorderStyle.None.ToString().Should().Be("none");
            BorderStyle.Hidden.ToString().Should().Be("hidden");
            BorderStyle.Dotted.ToString().Should().Be("dotted");
            BorderStyle.Dashed.ToString().Should().Be("dashed");
            BorderStyle.Solid.ToString().Should().Be("solid");
            BorderStyle.Double.ToString().Should().Be("double");
            BorderStyle.Groove.ToString().Should().Be("groove");
            BorderStyle.Ridge.ToString().Should().Be("ridge");
            BorderStyle.Inset.ToString().Should().Be("inset");
            BorderStyle.Outset.ToString().Should().Be("outset");
            BorderStyle.Inherit.ToString().Should().Be("inherit");
            BorderStyle.Initial.ToString().Should().Be("initial");
        }

        [Test]
        public void MultipleValuesRadius()
        {
            new BorderStyle(None, Dotted).ToString().Should().Be("none dotted");
            new BorderStyle(None, Dotted, Solid).ToString().Should().Be("none dotted solid");
            new BorderStyle(Double, Dotted, Solid, Dashed).ToString().Should().Be("double dotted solid dashed");
        }
    }
}
