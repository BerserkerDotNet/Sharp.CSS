using NUnit.Framework;
using Sharp.CSS.Types;

namespace Sharp.CSS.Tests.Border
{
    [TestFixture]
    public class BorderImageOutsetTests : TestsBase<BorderImageOutset>
    {
        [Test]
        public void StringValue()
        {
            VerifyValue(new("foo bla"), "foo bla");
            VerifyValue(BorderImageOutset.Inherit, "inherit");
            VerifyValue(BorderImageOutset.Initial, "initial");
        }

        [Test]
        public void ImplicitCast()
        {
            VerifyValue("foo bla", "foo bla");
            VerifyValue(45, "45");
            VerifyValue(45.4f, "45.4");
            VerifyValue(new CssSize(78), "78px");
        }

        [Test]
        public void MultipleValuesRadius()
        {
            VerifyValue(new(47), "47");
            VerifyValue(new(new CssSize(45)), "45px");
            VerifyValue(new(47, new CssSize(12)), "47 12px");
            VerifyValue(new(47, new CssSize(4), 45), "47 4px 45");
            VerifyValue(new(10, new CssSize(5), 2.5f, new CssSize(1)), "10 5px 2.5 1px");
        }
    }
}
