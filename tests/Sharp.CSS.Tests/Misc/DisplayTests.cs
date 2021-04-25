using FluentAssertions;
using NUnit.Framework;
using Sharp.CSS.Types;

namespace Sharp.CSS.Tests.Misc
{
    [TestFixture]
    class DisplayTests
    {
        [Test]
        public void DirectUse()
        {
            new Display("some weird value").ToString().Should().Be("some weird value");
            new Display(string.Empty).ToString().Should().Be(string.Empty);
            new Display(null).ToString().Should().Be(null);
        }

        [Test]
        public void FromString()
        {
            ((Display)"inline").ToString().Should().Be("inline");
            ((Display)"block").ToString().Should().Be("block");
            ((Display)"none").ToString().Should().Be("none");
        }
    }
}
