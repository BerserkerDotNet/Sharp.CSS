using NUnit.Framework;
using Sharp.CSS.Types;

namespace Sharp.CSS.Tests
{
    [TestFixture]
    public class MarginTests : TestsBase<Margin>
    {
        [Test]
        public void StringValue()
        {
            VerifyValue(new("fddfds"), "fddfds");
            VerifyValue(Margin.Auto, "auto");
            VerifyValue(Margin.Initial, "initial");
            VerifyValue(Margin.Inherit, "inherit");
        }

        [Test]
        public void ImplicitCast()
        {
            VerifyValue("21%", "21%");
            VerifyValue(78, "78px");
            VerifyValue(21.56f, "21.56px");
        }

        [Test]
        public void MultipleValues()
        {
            VerifyValue(new(14), "14px");
            VerifyValue(new(15, 30), "15px 30px");
            VerifyValue(new(15, 30, 10), "15px 30px 10px");
            VerifyValue(new(15, 30, 10, 5), "15px 30px 10px 5px");
        }
    }
}
