using FluentAssertions;
using NUnit.Framework;
using Sharp.CSS.Types;
using System.Collections;

namespace Sharp.CSS.Tests.Border
{
    [TestFixture]
    public class BorderRadiusTests
    {
        [Test]
        public void StringValue()
        {
            new BorderRadius("foo bla").ToString().Should().Be("foo bla");
            BorderRadius.Inherit.ToString().Should().Be("inherit");
            BorderRadius.Initial.ToString().Should().Be("initial");
        }

        [Test]
        public void SingleValueRadius()
        {
            new BorderRadius(20).ToString().Should().Be("20px");
            new BorderRadius(25.6f).ToString().Should().Be("25.6px");
            new BorderRadius(new CssSize(10, CssUnits.em)).ToString().Should().Be("10em");
        }

        [Test]
        public void MultipleValuesRadius()
        {
            new BorderRadius(20, 10).ToString().Should().Be("20px 10px");
            new BorderRadius(20, 10, 5).ToString().Should().Be("20px 10px 5px");
            new BorderRadius(20, 10, 5, 2.5f).ToString().Should().Be("20px 10px 5px 2.5px");
        }

        [TestCaseSource(typeof(BorderRadiusTests), nameof(SplitValuesRadiusCases))]
        public BorderRadius SplitValuesRadius(BorderRadius left, BorderRadius right)
        {
            return left / right;
        }

        public static IEnumerable SplitValuesRadiusCases
        {
            get
            {
                yield return new TestCaseData(new BorderRadius(20), new BorderRadius(10))
                    .Returns(new BorderRadius("20px / 10px"))
                    .SetName("Single value split");

                yield return new TestCaseData(new BorderRadius(20, 10, 5), new BorderRadius(16))
                    .Returns(new BorderRadius("20px 10px 5px / 16px"))
                    .SetName("Multiple values on the left single value right");

                yield return new TestCaseData(new BorderRadius(20), new BorderRadius(16, 10, 5))
                    .Returns(new BorderRadius("20px / 16px 10px 5px"))
                    .SetName("Multiple values on the right single value left");

                yield return new TestCaseData(new BorderRadius(20, 47), new BorderRadius(16, 10, 5))
                    .Returns(new BorderRadius("20px 47px / 16px 10px 5px"))
                    .SetName("Multiple values on both sides");
            }
        }
    }
}
