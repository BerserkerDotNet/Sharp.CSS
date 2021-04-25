using NUnit.Framework;
using Sharp.CSS.Types;

namespace Sharp.CSS.Tests.Border
{
    [TestFixture]
    public class BorderSpacingTests : TestsBase<BorderSpacing>
    {
        [Test]
        public void StringValue()
        {
            VerifyValue(new("foo bla"), "foo bla");
            VerifyValue(BorderSpacing.Inherit, "inherit");
            VerifyValue(BorderSpacing.Initial, "initial");
        }

        [Test]
        public void ImplicitCast()
        {
            VerifyValue("foo bla", "foo bla");
            VerifyValue(45, "45px");
            VerifyValue(45.4f, "45.4px");
            VerifyValue(new CssSize(78, CssUnits.percentage), "78%");
        }

        [Test]
        public void MultipleValuesRadius()
        {
            VerifyValue(new(47), "47px");
            VerifyValue(new(23, 45), "23px 45px");
        }
    }
}
