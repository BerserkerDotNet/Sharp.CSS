using FluentAssertions;
using NUnit.Framework;
using Sharp.CSS.Types;

namespace Sharp.CSS.Tests.Border
{
    [TestFixture]
    public class BorderSideStyleTest
    {
        [Test]
        public void StringValue()
        {
            new BorderSideStyle("foo bla").ToString().Should().Be("foo bla");
            BorderSideStyle.None.ToString().Should().Be("none");
            BorderSideStyle.Hidden.ToString().Should().Be("hidden");
            BorderSideStyle.Dotted.ToString().Should().Be("dotted");
            BorderSideStyle.Dashed.ToString().Should().Be("dashed");
            BorderSideStyle.Solid.ToString().Should().Be("solid");
            BorderSideStyle.Double.ToString().Should().Be("double");
            BorderSideStyle.Groove.ToString().Should().Be("groove");
            BorderSideStyle.Ridge.ToString().Should().Be("ridge");
            BorderSideStyle.Inset.ToString().Should().Be("inset");
            BorderSideStyle.Outset.ToString().Should().Be("outset");
            BorderSideStyle.Inherit.ToString().Should().Be("inherit");
            BorderSideStyle.Initial.ToString().Should().Be("initial");
        }
    }
}
