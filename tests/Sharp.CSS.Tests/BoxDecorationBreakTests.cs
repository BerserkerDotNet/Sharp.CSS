using NUnit.Framework;
using Sharp.CSS.Types;

namespace Sharp.CSS.Tests
{
    [TestFixture]
    public class BoxDecorationBreakTests : TestsBase<BoxDecorationBreak>
    {
        [Test]
        public void StringValue()
        {
            VerifyValue(new("fddfds"), "fddfds");
            VerifyValue(BoxDecorationBreak.Slice, "slice");
            VerifyValue(BoxDecorationBreak.Clone, "clone");
            VerifyValue(BoxDecorationBreak.Initial, "initial");
            VerifyValue(BoxDecorationBreak.Inherit, "inherit");
        }

        [Test]
        public void ImplicitCast()
        {
            VerifyValue("foo", "foo");
        }
    }
}
