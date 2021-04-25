using FluentAssertions;
using NUnit.Framework;
using Sharp.CSS.Types;

namespace Sharp.CSS.Tests.Border
{
    [TestFixture]
    public class BorderSideWidthTest
    {
        [Test]
        public void StringValue()
        {
            new BorderSideWidth("foo bla").ToString().Should().Be("foo bla");
            BorderSideWidth.Thin.ToString().Should().Be("thin");
            BorderSideWidth.Medium.ToString().Should().Be("medium");
            BorderSideWidth.Thick.ToString().Should().Be("thick");
            BorderSideWidth.Inherit.ToString().Should().Be("inherit");
            BorderSideWidth.Initial.ToString().Should().Be("initial");
        }

        [Test]
        public void SingleValueRadius()
        {
            ((BorderSideWidth)new Size(34)).ToString().Should().Be("34px");
            ((BorderSideWidth)4).ToString().Should().Be("4px");
            ((BorderSideWidth)7.5f).ToString().Should().Be("7.5px");
        }
    }
}
