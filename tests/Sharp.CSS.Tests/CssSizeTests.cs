using FluentAssertions;
using NUnit.Framework;
using Sharp.CSS.Types;

namespace Sharp.CSS.Tests
{
    [TestFixture]
    public class CssSizeTests
    {
        [Test]
        public void DirectUsage()
        {
            new CssSize(25).ToString().Should().Be("25px");
            new CssSize(30, CssUnits.rem).ToString().Should().Be("30rem");
            new CssSize(99, CssUnits.percentage).ToString().Should().Be("99%");
            new CssSize(25.6f, CssUnits.@in).ToString().Should().Be("25.6in");
            new CssSize(0.63f, CssUnits.em).ToString().Should().Be("0.63em");
        }

        [Test]
        public void FromInteger()
        {
            ((CssSize)25).ToString().Should().Be("25px");
            ((CssSize)99).ToString().Should().Be("99px");
            ((CssSize)25.6).ToString().Should().Be("25.6px");
            ((CssSize)0.63).ToString().Should().Be("0.63px");
        }

        [Test]
        public void FromString()
        {
            ((CssSize)"25px").ToString().Should().Be("25px");
            ((CssSize)"foo").ToString().Should().Be("foo");
            ((CssSize)string.Empty).ToString().Should().Be("");
        }

        [Test]
        public void FromPreDefined()
        {
            CssSize.None.ToString().Should().Be("none");
            CssSize.Initial.ToString().Should().Be("initial");
            CssSize.Inherit.ToString().Should().Be("inherit");
        }
    }
}
