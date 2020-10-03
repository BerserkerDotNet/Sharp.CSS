using FluentAssertions;
using NUnit.Framework;
using Sharp.CSS.Types;
using System.Drawing;

namespace Sharp.CSS.Tests
{
    [TestFixture]
    public class BackgroundTests
    {
        [Test]
        public void FromString()
        {
            ((Background)"red no-repeat fixed center").ToString().Should().Be("red no-repeat fixed center");
        }

        [Test]
        public void ColorPositionSizeRepeat()
        {
            new Background(
                color: Color.Red,
                position: BackgroundPosition.CenterBottom,
                size: new BackgroundSize(20, 50),
                repeat: BackgroundRepeat.NoRepeat)
            .ToString().Should().Be("red center bottom / 20px 50px no-repeat");
        }

        [Test]
        public void ImagePositionSizeRepeat()
        {
            new Background(
                image: new Url("https://foo.png"),
                position: BackgroundPosition.CenterBottom,
                size: new BackgroundSize(70, 30),
                repeat: BackgroundRepeat.NoRepeat)
            .ToString().Should().Be("url(https://foo.png) center bottom / 70px 30px no-repeat");
        }

        [Test]
        public void ColorImagePositionSizeRepeat()
        {
            new Background(
                color: Color.Red,
                image: new Url("https://foo.png"),
                position: BackgroundPosition.CenterBottom,
                size: new BackgroundSize(70, 30),
                repeat: BackgroundRepeat.NoRepeat)
            .ToString().Should().Be("red url(https://foo.png) center bottom / 70px 30px no-repeat");
        }

        [Test]
        public void ColorImagePositionNoSizeRepeat()
        {
            new Background(
                color: Color.Red,
                image: new Url("https://foo.png"),
                position: BackgroundPosition.CenterBottom,
                repeat: BackgroundRepeat.NoRepeat)
            .ToString().Should().Be("red url(https://foo.png) center bottom no-repeat");
        }

        [Test]
        public void ColorImageNoPositionSizeRepeat()
        {
            new Background(
                color: Color.Red,
                image: new Url("https://foo.png"),
                size: new BackgroundSize(70, 30),
                repeat: BackgroundRepeat.NoRepeat)
            .ToString().Should().Be("red url(https://foo.png) no-repeat");
        }

        [Test]
        public void AllParameters()
        {
            new Background(
                color: Color.Red,
                image: new Url("https://foo.png"),
                position: BackgroundPosition.CenterBottom,
                size: new BackgroundSize(70, 30),
                repeat: BackgroundRepeat.NoRepeat,
                origin: Sizing.PaddingBox,
                clip: Sizing.ContentBox,
                attachment: BackgroundAttachment.Fixed)
            .ToString().Should().Be("red url(https://foo.png) center bottom / 70px 30px no-repeat padding-box content-box fixed");
        }
    }
}
