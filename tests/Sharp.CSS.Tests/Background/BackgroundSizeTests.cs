using FluentAssertions;
using NUnit.Framework;
using Sharp.CSS.Types;

namespace Sharp.CSS.Tests
{
    [TestFixture]
    public class BackgroundSizeTests
    {
        [Test]
        public void DirectUsage()
        {
            new BackgroundSize(25, 35).ToString().Should().Be("25px 35px");
            new BackgroundSize(50, new CssSize(45, CssUnits.percentage)).ToString().Should().Be("50px 45%");
        }

        [Test]
        public void FromInteger()
        {
            ((BackgroundSize)25).ToString().Should().Be("25px auto");
            ((BackgroundSize)99).ToString().Should().Be("99px auto");
            ((BackgroundSize)25.6).ToString().Should().Be("25.6px auto");
            ((BackgroundSize)0.63).ToString().Should().Be("0.63px auto");
        }

        [Test]
        public void FromString()
        {
            ((BackgroundSize)"25px").ToString().Should().Be("25px");
            ((BackgroundSize)"foo").ToString().Should().Be("foo");
            ((BackgroundSize)string.Empty).ToString().Should().Be("");
        }

        [Test]
        public void FromPreDefined()
        {
            BackgroundSize.Initial.ToString().Should().Be("initial");
            BackgroundSize.Inherit.ToString().Should().Be("inherit");
            BackgroundSize.Auto.ToString().Should().Be("auto");
            BackgroundSize.Contain.ToString().Should().Be("contain");
            BackgroundSize.Cover.ToString().Should().Be("cover");
        }
    }
}
