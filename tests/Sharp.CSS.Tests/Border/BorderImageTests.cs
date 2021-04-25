using FluentAssertions;
using NUnit.Framework;
using Sharp.CSS.Types;
using System.Drawing;

namespace Sharp.CSS.Tests.Border
{
    [TestFixture]
    public class BorderImageTests: TestsBase<BorderImage>
    {
        [Test]
        public void StringValue()
        {
            VerifyValue(new BorderImage("foo bla"), "foo bla");
            VerifyValue("foo bla", "foo bla");
            VerifyValue(BorderImage.Inherit, "inherit");
            VerifyValue(BorderImage.Initial, "initial");
        }

        [Test]
        public void MultipleValuesRadius()
        {
            VerifyValue(new (new LinearGradient(Color.Red, Color.Blue), 27), "linear-gradient(0deg, red, blue) 27");
            VerifyValue(new (new Url("/images/border.png"), 27, BorderImageRepeat.Space), "url(/images/border.png) 27 space");
            VerifyValue(new (new LinearGradient(Color.Red, Color.Blue), 27, 35), "linear-gradient(0deg, red, blue) 27 / 35px");
            VerifyValue(new(
                new LinearGradient(Color.Red, Color.Blue),
                new BorderImageSlice(27, 23),
                new BorderImageWidth(50, 30),
                new Types.Size(1, CssUnits.rem),
                new BorderImageRepeat(BorderImageRepeat.Round, BorderImageRepeat.Space)), "linear-gradient(0deg, red, blue) 27 23 / 50px 30px / 1rem round space");
        }
    }
}
