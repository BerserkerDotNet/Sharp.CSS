using NUnit.Framework;
using Sharp.CSS.Types;
using System.Drawing;

namespace Sharp.CSS.Tests
{
    [TestFixture]
    public class BoxShadowTests : TestsBase<BoxShadow>
    {
        [Test]
        public void StringValue()
        {
            VerifyValue(new("fddfds"), "fddfds");
            VerifyValue(BoxShadow.None, "none");
            VerifyValue(BoxShadow.Initial, "initial");
            VerifyValue(BoxShadow.Inherit, "inherit");
        }

        [Test]
        public void ImplicitCast()
        {
            VerifyValue("super shadow", "super shadow");
        }

        [Test]
        public void MultipleValues()
        {
            VerifyValue(new(15, 30), "15px 30px");
            VerifyValue(new(15, 30, inset: true), "15px 30px inset");
            VerifyValue(new(15, 30, Color.Green, inset: true), "15px 30px green inset");
            VerifyValue(new(15, 30, 10), "15px 30px 10px");
            VerifyValue(new(15, 30, 10, Color.Yellow), "15px 30px 10px yellow");
            VerifyValue(new(15, 30, 10, 5), "15px 30px 10px 5px");
            VerifyValue(new(15, 30, 10, 5, Color.Red), "15px 30px 10px 5px red");
            VerifyValue(new(15, 30, 10, 5, Color.Red, inset: true), "15px 30px 10px 5px red inset");
        }

        [Test]
        public void MultipleShadows()
        {
            var shadow = new BoxShadow(15, 30) +
                new BoxShadow(5, 30, Color.Blue) +
                new BoxShadow(5, 30, 45, 14, Color.Red) +
                new BoxShadow(10, 8, 12, 7, inset: true);

            VerifyValue(shadow, "15px 30px, 5px 30px blue, 5px 30px 45px 14px red, 10px 8px 12px 7px inset");
        }
    }
}
