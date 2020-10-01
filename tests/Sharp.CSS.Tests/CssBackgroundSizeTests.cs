using FluentAssertions;
using NUnit.Framework;
using Sharp.CSS.Types;

namespace Sharp.CSS.Tests
{
    [TestFixture]
    public class CssBackgroundSizeTests
    {
        [Test]
        public void DirectUsage()
        {
            new CssBackgroundSize(25).ToString().Should().Be("25px");
            new CssBackgroundSize(30, CssUnits.rem).ToString().Should().Be("30rem");
            new CssBackgroundSize(99, CssUnits.percentage).ToString().Should().Be("99%");
            new CssBackgroundSize(25.6f, CssUnits.@in).ToString().Should().Be("25.6in");
            new CssBackgroundSize(0.63f, CssUnits.em).ToString().Should().Be("0.63em");
        }

        [Test]
        public void FromInteger()
        {
            ((CssBackgroundSize)25).ToString().Should().Be("25px");
            ((CssBackgroundSize)99).ToString().Should().Be("99px");
            ((CssBackgroundSize)25.6).ToString().Should().Be("25.6px");
            ((CssBackgroundSize)0.63).ToString().Should().Be("0.63px");
        }

        [Test]
        public void FromString()
        {
            ((CssBackgroundSize)"25px").ToString().Should().Be("25px");
            ((CssBackgroundSize)"foo").ToString().Should().Be("foo");
            ((CssBackgroundSize)string.Empty).ToString().Should().Be("");
        }

        [Test]
        public void FromPreDefined()
        {
            CssBackgroundSize.None.ToString().Should().Be("none");
            CssBackgroundSize.Initial.ToString().Should().Be("initial");
            CssBackgroundSize.Inherit.ToString().Should().Be("inherit");
            CssBackgroundSize.Auto.ToString().Should().Be("auto");
            CssBackgroundSize.Contain.ToString().Should().Be("contain");
            CssBackgroundSize.Cover.ToString().Should().Be("cover");
        }
    }
}
