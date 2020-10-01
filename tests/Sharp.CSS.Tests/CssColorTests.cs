using FluentAssertions;
using NUnit.Framework;
using Sharp.CSS.Types;
using System.Drawing;

namespace Sharp.CSS.Tests
{
    [TestFixture]
    public class CssColorTests
    {
        [Test]
        public void DirectUse()
        {
            new CssColor("rgba(255,0,0,0.3)").ToString().Should().Be("rgba(255,0,0,0.3)");
            new CssColor(string.Empty).ToString().Should().Be(string.Empty);
            new CssColor(null).ToString().Should().Be(null);
        }

        [Test]
        public void FromColor()
        {
            ((CssColor)Color.Red).ToString().Should().Be("red");
            ((CssColor)Color.LightGoldenrodYellow).ToString().Should().Be("lightgoldenrodyellow");
            ((CssColor)Color.FromArgb(50, 200, 0, 127)).ToString().Should().Be("#C8007F32");
            ((CssColor)Color.FromArgb(0, 200, 0, 127)).ToString().Should().Be("#C8007F00");
            ((CssColor)Color.FromArgb(255, 200, 0, 127)).ToString().Should().Be("#C8007F");
        }

        [Test]
        public void FromString()
        {
            ((CssColor)"red").ToString().Should().Be("red");
            ((CssColor)"#3F004A").ToString().Should().Be("#3F004A");
            ((CssColor)"Bla").ToString().Should().Be("Bla");
        }
    }
}
