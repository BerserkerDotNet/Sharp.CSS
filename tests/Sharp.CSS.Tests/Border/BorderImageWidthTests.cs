using NUnit.Framework;
using Sharp.CSS.Types;

namespace Sharp.CSS.Tests.Border
{
    [TestFixture]
    public class BorderImageWidthTests : TestsBase<BorderImageWidth>
    {
        [Test]
        public void StringValue()
        {
            VerifyValue(new("foo bla"), "foo bla");
            VerifyValue(BorderImageWidth.Auto, "auto");
            VerifyValue(BorderImageWidth.Inherit, "inherit");
            VerifyValue(BorderImageWidth.Initial, "initial");
        }

        [Test]
        public void ImplicitCast()
        {
            VerifyValue("foo bla", "foo bla");
            VerifyValue(45, "45px");
            VerifyValue(new Size(78), "78px");
        }

        [Test]
        public void MultipleValuesRadius()
        {
            VerifyValue(new (47), "47px");
            VerifyValue(new (47, 12), "47px 12px");
            VerifyValue(new (47, 4, 45), "47px 4px 45px");
            VerifyValue(new (10, 5, 2.5f, 1), "10px 5px 2.5px 1px");
        }
    }
}
