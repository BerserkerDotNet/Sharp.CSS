using FluentAssertions;
using NUnit.Framework;
using Sharp.CSS.Types;

namespace Sharp.CSS.Tests.Border
{
    [TestFixture]
    public class BorderSideRadiusTests
    {
        [Test]
        public void StringValue()
        {
            new BorderSideRadius("foo bla").ToString().Should().Be("foo bla");
            BorderSideRadius.Inherit.ToString().Should().Be("inherit");
            BorderSideRadius.Initial.ToString().Should().Be("initial");
        }

        [Test]
        public void SingleValueRadius()
        {
            new BorderSideRadius(20).ToString().Should().Be("20px");
            new BorderSideRadius(25.6f).ToString().Should().Be("25.6px");
            new BorderSideRadius(new CssSize(10, CssUnits.em)).ToString().Should().Be("10em");
        }

        [Test]
        public void MultipleValuesRadius()
        {
            new BorderSideRadius(20, 10).ToString().Should().Be("20px 10px");
        }
    }
}
