using NUnit.Framework;
using Sharp.CSS.Types;

namespace Sharp.CSS.Tests.Border
{
    [TestFixture]
    public class BorderImageRepeatTest : TestsBase<BorderImageRepeat>
    {
        [Test]
        public void StringValue()
        {
            VerifyValue(new("foo bla"), "foo bla");
            VerifyValue(BorderImageRepeat.Repeat, "repeat");
            VerifyValue(BorderImageRepeat.Round, "round");
            VerifyValue(BorderImageRepeat.Space, "space");
            VerifyValue(BorderImageRepeat.Stretch, "stretch");
            VerifyValue(BorderImageRepeat.Inherit, "inherit");
            VerifyValue(BorderImageRepeat.Initial, "initial");
        }

        [Test]
        public void ImplicitCast()
        {
            VerifyValue("foo bla", "foo bla");
        }

        [Test]
        public void MultipleValuesRadius()
        {
            VerifyValue(new(BorderImageRepeat.Repeat, BorderImageRepeat.Round), "repeat round");
        }
    }
}
