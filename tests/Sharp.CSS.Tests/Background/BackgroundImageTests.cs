using FluentAssertions;
using NUnit.Framework;
using Sharp.CSS.Types;
using System.Drawing;

namespace Sharp.CSS.Tests
{
    [TestFixture]
    public class BackgroundImageTests
    {
        [Test]
        public void DirectUse()
        {
            new BackgroundImage("some image").ToString().Should().Be("some image");
            new BackgroundImage("url('https://image.com')").ToString().Should().Be("url('https://image.com')");
        }

        [Test]
        public void FromUrl()
        {
            ((BackgroundImage)new Url("https://image.com")).ToString().Should().Be("url(https://image.com)");
        }

        [Test]
        public void FromGradients()
        {
            ((BackgroundImage)new LinearGradient(Color.Red, Color.Green, Color.Blue)).ToString().Should().Be("linear-gradient(0deg, red, green, blue)");
            ((BackgroundImage)new RadialGradient(Color.Red, Color.Green, Color.Blue)).ToString().Should().Be("radial-gradient(ellipse, red, green, blue)");
            ((BackgroundImage)new RepeatingGradient<RadialGradient>(new RadialGradient(Color.Red, Color.Green, Color.Blue))).ToString().Should().Be("repeating-radial-gradient(ellipse, red, green, blue)");
            ((BackgroundImage)new RepeatingGradient<LinearGradient>(new LinearGradient(Color.Red, Color.Green, Color.Blue))).ToString().Should().Be("repeating-linear-gradient(0deg, red, green, blue)");
        }

        [Test]
        public void FromPredefinedValues()
        {
            BackgroundImage.None.ToString().Should().Be("none");
            BackgroundImage.Inherit.ToString().Should().Be("inherit");
            BackgroundImage.Initial.ToString().Should().Be("initial");
        }
    }
}
