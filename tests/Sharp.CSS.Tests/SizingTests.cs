using FluentAssertions;
using NUnit.Framework;
using Sharp.CSS.Types;

namespace Sharp.CSS.Tests
{
    [TestFixture]
    public class SizingTests
    {
        [Test]
        public void DirectUse()
        {
            new Sizing("some weird value").ToString().Should().Be("some weird value");
        }

        [Test]
        public void FRomPredefinedValue()
        {
            Sizing.Inherit.ToString().Should().Be("inherit");
            Sizing.Initial.ToString().Should().Be("initial");
            Sizing.PaddingBox.ToString().Should().Be("padding-box");
            Sizing.BorderBox.ToString().Should().Be("border-box");
            Sizing.ContentBox.ToString().Should().Be("content-box");
        }
    }
}
