using FluentAssertions;
using NUnit.Framework;
using Sharp.CSS.Types;

namespace Sharp.CSS.Tests
{
    [TestFixture]
    public class UrlTests
    {
        [Test]
        public void GenerateFromString()
        {
            new Url("").ToString().Should().Be("url()");
            new Url("foo").ToString().Should().Be("url(foo)");
            new Url("https://bla/foo?fff").ToString().Should().Be("url(https://bla/foo?fff)");
        }
    }
}
