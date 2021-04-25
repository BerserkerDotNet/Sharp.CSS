using NUnit.Framework;
using Sharp.CSS.Types;

namespace Sharp.CSS.Tests.Border
{
    [TestFixture]
    public class BorderCollapseTests : TestsBase<BorderCollapse>
    {
        [Test]
        public void StringValue()
        {
            VerifyValue(new("foo bla"), "foo bla");
            VerifyValue(BorderCollapse.Collapse, "collapse");
            VerifyValue(BorderCollapse.Separate, "separate");
            VerifyValue(BorderCollapse.Inherit, "inherit");
            VerifyValue(BorderCollapse.Initial, "initial");
        }

        [Test]
        public void ImplicitCast()
        {
            VerifyValue("foo bla", "foo bla");
        }
    }
}
