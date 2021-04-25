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
            new Size(25).ToString().Should().Be("25px");
            new Size(30, CssUnits.rem).ToString().Should().Be("30rem");
            new Size(99, CssUnits.percentage).ToString().Should().Be("99%");
            new Size(25.6f, CssUnits.@in).ToString().Should().Be("25.6in");
            new Size(0.63f, CssUnits.em).ToString().Should().Be("0.63em");
        }

        [Test]
        public void FromInteger()
        {
            ((Size)25).ToString().Should().Be("25px");
            ((Size)99).ToString().Should().Be("99px");
            ((Size)25.6).ToString().Should().Be("25.6px");
            ((Size)0.63).ToString().Should().Be("0.63px");
        }

        [Test]
        public void FromString()
        {
            ((Size)"25px").ToString().Should().Be("25px");
            ((Size)"foo").ToString().Should().Be("foo");
            ((Size)string.Empty).ToString().Should().Be("");
        }

        [Test]
        public void FromPreDefined()
        {
            Size.None.ToString().Should().Be("none");
            Size.Initial.ToString().Should().Be("initial");
            Size.Inherit.ToString().Should().Be("inherit");
        }
    }
}
