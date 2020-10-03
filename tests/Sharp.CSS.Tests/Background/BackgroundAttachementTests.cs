using FluentAssertions;
using NUnit.Framework;
using Sharp.CSS.Types;

namespace Sharp.CSS.Tests
{
    [TestFixture]
    public class BackgroundAttachementTests
    {
        [Test]
        public void DirectUse()
        {
            new BackgroundAttachment("stick").ToString().Should().Be("stick");
        }

        [Test]
        public void FromPredefinedValue()
        {
            BackgroundAttachment.Inherit.ToString().Should().Be("inherit");
            BackgroundAttachment.Initial.ToString().Should().Be("initial");
            BackgroundAttachment.Scroll.ToString().Should().Be("scroll");
            BackgroundAttachment.Fixed.ToString().Should().Be("fixed");
            BackgroundAttachment.Local.ToString().Should().Be("local");
        }
    }
}
