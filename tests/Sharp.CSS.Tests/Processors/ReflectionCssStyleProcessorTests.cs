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

            _processor.Process("foo", new StyleSet { })
                .Should().Be(".foo{}");
        }

        [Test]
        public void ConvertsPropertiesToClass()
        {
            var result = _processor.Process("block", new StyleSet
            {
                Width = 100,
                Height = 50,
                MinWidth = 50,
                MinHeight = 25,
                MaxWidth = 200,
                MaxHeight = 100
            });

            result.Should().Be(".block{max-width: 200px;max-height: 100px;min-width: 50px;min-height: 25px;width: 100px;height: 50px;}");
        }

        [Test]
        public void IgnoresNotSetProperties()
        {
            var result = _processor.Process("block", new StyleSet
            {
                Width = 500,
                Height = 250,
            });

            result.Should().Be(".block{width: 500px;height: 250px;}");
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
                .With("font-size", new CssSize(42))
                .With("font-color", "green")
                .With("border-radius", 20)
                .With("composite", "'foo bla bar'");

            var result = _processor.Process("dynamic", styleSet);

            result.Should().Be(".dynamic{width: 500px;height: 250px;font-size: 42px;font-color: green;border-radius: 20;composite: 'foo bla bar';}");
        }
    }
}