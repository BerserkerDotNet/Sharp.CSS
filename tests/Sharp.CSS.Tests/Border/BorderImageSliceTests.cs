using NUnit.Framework;
using Sharp.CSS.Types;

namespace Sharp.CSS.Tests.Border
{
    [TestFixture]
    public class BorderImageSliceTests : TestsBase<BorderImageSlice>
    {
        [Test]
        public void StringValue()
        {
            VerifyValue(new("foo bla"), "foo bla");
            VerifyValue(BorderImageSlice.Fill, "fill");
            VerifyValue(BorderImageSlice.Inherit, "inherit");
            VerifyValue(BorderImageSlice.Initial, "initial");
        }

        [Test]
        public void ImplicitCast()
        {
            VerifyValue("foo bla", "foo bla");
            VerifyValue(45, "45");
            VerifyValue(45.4f, "45.4");
            VerifyValue(new Percentage(78), "78%");
        }

        [Test]
        public void MultipleValuesRadius()
        {
            VerifyValue(new(47), "47");
            VerifyValue(new(new Percentage(45)), "45%");
            VerifyValue(new(47, new Percentage(12)), "47 12%");
            VerifyValue(new(47, new Percentage(4), 45), "47 4% 45");
            VerifyValue(new(10, new Percentage(5), 2.5f, new Percentage(1)), "10 5% 2.5 1%");
        }
    }
}
