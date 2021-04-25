using FluentAssertions;
using NUnit.Framework;
using Sharp.CSS.Types;
using System.Drawing;

namespace Sharp.CSS.Tests.Border
{
    [TestFixture]
    public class BorderColorTests
    {
        [Test]
        public void StringValue()
        {
            new BorderColor("foo bla").ToString().Should().Be("foo bla");
            BorderColor.Inherit.ToString().Should().Be("inherit");
            BorderColor.Initial.ToString().Should().Be("initial");
        }

        [Test]
        public void SingleValueRadius()
        {
            ((BorderColor)Color.Green).ToString().Should().Be("green");
        }

        [Test]
        public void MultipleValuesRadius()
        {
            new BorderColor(Color.Green, Color.Red).ToString().Should().Be("green red");
            new BorderColor(Color.Green, Color.Red, Color.Blue).ToString().Should().Be("green red blue");
            new BorderColor(Color.Green, Color.Red, Color.Blue, Color.Violet).ToString().Should().Be("green red blue violet");
        }
    }
}
