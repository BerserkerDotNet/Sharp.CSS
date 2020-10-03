using FluentAssertions;
using NUnit.Framework;
using Sharp.CSS.Types;

namespace Sharp.CSS.Tests
{
    [TestFixture]
    public class BackgroundRepeatTest
    {
        [Test]
        public void DirectUse()
        {
            new BackgroundRepeat("some weird value").ToString().Should().Be("some weird value");
        }

        [Test]
        public void FromPredefinedValue()
        {
            BackgroundRepeat.Inherit.ToString().Should().Be("inherit");
            BackgroundRepeat.Initial.ToString().Should().Be("initial");
            BackgroundRepeat.NoRepeat.ToString().Should().Be("no-repeat");
            BackgroundRepeat.Repeat.ToString().Should().Be("repeat");
            BackgroundRepeat.RepeatX.ToString().Should().Be("repeat-x");
            BackgroundRepeat.RepeatY.ToString().Should().Be("repeat-y");
            BackgroundRepeat.Round.ToString().Should().Be("round");
            BackgroundRepeat.Space.ToString().Should().Be("space");
        }
    }
}
