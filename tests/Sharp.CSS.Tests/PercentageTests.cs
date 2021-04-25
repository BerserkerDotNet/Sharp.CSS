using NUnit.Framework;
using Sharp.CSS.Types;

namespace Sharp.CSS.Tests
{
    [TestFixture]
    public class PercentageTests : TestsBase<Percentage>
    {
        [Test]
        public void StringValue()
        {
            VerifyValue(new("fddfds"), "fddfds");
        }

        [Test]
        public void ImplicitCast()
        {
            VerifyValue("21%", "21%");
            VerifyValue(78, "78%");
            VerifyValue(21.56f, "21.56%");
        }
    }
}
