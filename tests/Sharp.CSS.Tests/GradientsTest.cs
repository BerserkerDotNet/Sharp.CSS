using FluentAssertions;
using NUnit.Framework;
using Sharp.CSS.Types;
using System.Drawing;

namespace Sharp.CSS.Tests
{
    [TestFixture]
    public class GradientsTest
    {
        [Test]
        public void LinierGradient()
        {
            new LinearGradient(Color.Red, Color.Green, Color.Blue).ToString().Should().Be("linear-gradient(0deg, red, green, blue)");
            new LinearGradient(45, Color.Red, Color.Green, Color.Blue).ToString().Should().Be("linear-gradient(45deg, red, green, blue)");
        }

        [Test]
        public void RadialGradient()
        {
            new RadialGradient(Color.Red, Color.Green, Color.Blue).ToString().Should().Be("radial-gradient(ellipse, red, green, blue)");
            new RadialGradient("circle", Color.Red, Color.Green, Color.Blue).ToString().Should().Be("radial-gradient(circle, red, green, blue)");
        }

        [Test]
        public void Repeatable()
        {
            var linear = new LinearGradient(Color.Red, Color.Green, Color.Blue);
            var radial = new RadialGradient(Color.Red, Color.Green, Color.Blue);

            new RepeatingGradient<LinearGradient>(linear).ToString().Should().Be("repeating-linear-gradient(0deg, red, green, blue)");
            new RepeatingGradient<RadialGradient>(radial).ToString().Should().Be("repeating-radial-gradient(ellipse, red, green, blue)");
        }
    }
}
