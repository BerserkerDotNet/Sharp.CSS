using FluentAssertions;
using NUnit.Framework;
using Sharp.CSS.CssStyleSets;
using Sharp.CSS.Services;

namespace Sharp.CSS.Tests.Services
{
    public class CssStyleServiceTests
    {
        private CssStyleService _service;

        [SetUp]
        public void SetUp()
        {
            _service = new CssStyleService(new ReflectionCssStyleProcessor());
        }


        [Test]
        public void GeneratesDefaultClassName()
        {
            var set = new StyleSet { BackgroundColor = "blue" };
            var result = _service.GetClassName(set);

            result.Should().Be("cssStyle-0");
        }

        [Test]
        public void UseProvidedClassNameClassName()
        {
            var set = new StyleSet { BackgroundColor = "blue" };
            var result = _service.GetClassName(set, "customName");

            result.Should().Be("customName-0");
        }

        [Test]
        public void RepeatedCallsToGetClassNameGenerateDifferentClasses()
        {
            var set = new StyleSet { BackgroundColor = "blue" };

            _service.GetClassName(set).Should().Be("cssStyle-0");
            _service.GetClassName(set).Should().Be("cssStyle-1");
            _service.GetClassName(set).Should().Be("cssStyle-2");
            _service.GetClassName(set).Should().Be("cssStyle-3");

            _service.GetClassName(set, "customName").Should().Be("customName-0");
            _service.GetClassName(set, "customName").Should().Be("customName-1");
            _service.GetClassName(set, "customName").Should().Be("customName-2");
            _service.GetClassName(set, "customName").Should().Be("customName-3");
        }
    }
}
