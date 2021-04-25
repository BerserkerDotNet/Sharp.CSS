using FluentAssertions;
using NUnit.Framework;
using Sharp.CSS.CssStyleSets;
using Sharp.CSS.Services;
using Sharp.CSS.Types;
using System;
using System.Drawing;

namespace Sharp.CSS.Tests
{
    public class ReflectionCssStyleProcessorTests
    {
        private ReflectionCssStyleProcessor _processor;

        [SetUp]
        public void Setup()
        {
            _processor = new ReflectionCssStyleProcessor();
        }

        [Test]
        public void EmptyClassName([Values(null, "", " ", "  ", "   ")]string className)
        {
            _processor.Invoking(p => p.Process(className, new StyleSet { }))
                .Should().Throw<ArgumentNullException>($"{nameof(className)} cannot be empty");
        }

        [Test]
        public void EmptyStyle()
        {
            _processor.Invoking(p => p.Process("foo", null))
                .Should().Throw<ArgumentNullException>($"style cannot be null");

            var set = new StyleSet { };

            _processor.Process("foo", set)
                .Should().Be(".foo{}");
            _processor.Process(set)
                .Should().Be(string.Empty);
        }

        [Test]
        public void ConvertsPropertiesToClass()
        {
            var set = new StyleSet
            {
                Width = 100,
                Height = 50,
                MinWidth = 50,
                MinHeight = 25,
                MaxWidth = 200,
                MaxHeight = 100
            };

            _processor.Process("block", set).Should().Be(".block{max-width: 200px;max-height: 100px;min-width: 50px;min-height: 25px;width: 100px;height: 50px;}");
            _processor.Process(set).Should().Be("max-width: 200px;max-height: 100px;min-width: 50px;min-height: 25px;width: 100px;height: 50px;");
        }

        [Test]
        public void IgnoresNotSetProperties()
        {
            var set = new StyleSet
            {
                Width = 500,
                Height = 250,
            };

            _processor.Process("block", set).Should().Be(".block{width: 500px;height: 250px;}");
            _processor.Process(set).Should().Be("width: 500px;height: 250px;");
        }

        [Test]
        public void ProcessDynamicValues()
        {
            var styleSet = new StyleSet
            {
                Width = 500,
                Height = 250,
            };

            styleSet
                .With("font-size", new Types.Size(42))
                .With("font-color", "green")
                .With("border-radius", 20)
                .With("composite", "'foo bla bar'");

            _processor.Process("dynamic", styleSet)
                .Should().Be(".dynamic{width: 500px;height: 250px;font-size: 42px;font-color: green;border-radius: 20;composite: 'foo bla bar';}");

            _processor.Process(styleSet)
                .Should().Be("width: 500px;height: 250px;font-size: 42px;font-color: green;border-radius: 20;composite: 'foo bla bar';");
        }

        [TestCase("")]
        [TestCase(" ")]
        [TestCase("some random thing")]
        [TestCase("{value:bla}")]
        public void WrapInClassAnyValue(string value)
        {
            var expected = $".foo{{{value}}}";
            _processor.WrapInClassSelector("foo", value).Should().Be(expected);
        }
    }
}