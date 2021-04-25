using FluentAssertions;
using NUnit.Framework;
using System.Drawing;
using static Sharp.CSS.Types.BorderSideStyle;

namespace Sharp.CSS.Tests.Border
{
    [TestFixture]
    public class BorderTests
    {
        [Test]
        public void StringValue()
        {
            new Types.Border("foo bla").ToString().Should().Be("foo bla");
            Types.Border.Inherit.ToString().Should().Be("inherit");
            Types.Border.Initial.ToString().Should().Be("initial");
        }

        [Test]
        public void SingleValueRadius()
        {
            new Types.Border(Dotted).ToString().Should().Be("dotted");
        }

        [Test]
        public void MultipleValuesRadius()
        {
            new Types.Border(Dotted, Color.Red).ToString().Should().Be("dotted red");
            new Types.Border(45, Dotted).ToString().Should().Be("45px dotted");
            new Types.Border(45, Dotted, Color.Red).ToString().Should().Be("45px dotted red");
        }
    }
}
