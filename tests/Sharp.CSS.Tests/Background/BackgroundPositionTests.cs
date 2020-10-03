using FluentAssertions;
using NUnit.Framework;
using Sharp.CSS.Types;

namespace Sharp.CSS.Tests
{
    [TestFixture]
    public class BackgroundPositionTests
    {
        [Test]
        public void DirectUse()
        {
            new BackgroundPosition("left").ToString().Should().Be("left");
            new BackgroundPosition("fooo bla").ToString().Should().Be("fooo bla");
            new BackgroundPosition(10, 20, CssUnits.em).ToString().Should().Be("10em 20em");
            new BackgroundPosition(45, 78, CssUnits.percentage).ToString().Should().Be("45% 78%");
            new BackgroundPosition(4.5f, 6.2f, CssUnits.rem).ToString().Should().Be("4.5rem 6.2rem");
        }

        [Test]
        public void FromString()
        {
            ((BackgroundPosition)"left").ToString().Should().Be("left");
            ((BackgroundPosition)"left whatever").ToString().Should().Be("left whatever");
        }

        [Test]
        public void PredefinedValues()
        {
            BackgroundPosition.CenterBottom.ToString().Should().Be("center bottom");
            BackgroundPosition.CenterCenter.ToString().Should().Be("center center");
            BackgroundPosition.CenterTop.ToString().Should().Be("center top");
            BackgroundPosition.LeftBottom.ToString().Should().Be("left bottom");
            BackgroundPosition.LeftCenter.ToString().Should().Be("left center");
            BackgroundPosition.LeftTop.ToString().Should().Be("left top");
            BackgroundPosition.RightBottom.ToString().Should().Be("right bottom");
            BackgroundPosition.RightCenter.ToString().Should().Be("right center");
            BackgroundPosition.RightTop.ToString().Should().Be("right top");
        }
    }
}
