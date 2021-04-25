using NUnit.Framework;
using Sharp.CSS.Types;

namespace Sharp.CSS.Tests
{
    [TestFixture]
    public class BoxSizingTests : TestsBase<BoxSizing>
    {
        [Test]
        public void StringValue()
        {
            VerifyValue(new("fddfds"), "fddfds");
            VerifyValue(BoxSizing.BorderBox, "border-box");
            VerifyValue(BoxSizing.ContentBox, "content-box");
            VerifyValue(BoxSizing.Initial, "initial");
            VerifyValue(BoxSizing.Inherit, "inherit");
        }

        [Test]
        public void ImplicitCast()
        {
            VerifyValue("foo", "foo");
        }
    }
}
