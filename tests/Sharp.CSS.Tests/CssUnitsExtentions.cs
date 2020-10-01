using FluentAssertions;
using NUnit.Framework;
using Sharp.CSS.Extensions;
using Sharp.CSS.Types;

namespace Sharp.CSS.Tests
{
    [TestFixture]
    public class CssUnitsExtentionsTests
    {
        [TestCase(CssUnits.ch, "ch")]
        [TestCase(CssUnits.cm, "cm")]
        [TestCase(CssUnits.em, "em")]
        [TestCase(CssUnits.ex, "ex")]
        [TestCase(CssUnits.@in, "in")]
        [TestCase(CssUnits.mm, "mm")]
        [TestCase(CssUnits.pc, "pc")]
        [TestCase(CssUnits.percentage, "%")]
        [TestCase(CssUnits.pt, "pt")]
        [TestCase(CssUnits.px, "px")]
        [TestCase(CssUnits.rem, "rem")]
        [TestCase(CssUnits.vh, "vh")]
        [TestCase(CssUnits.vm, "vm")]
        [TestCase(CssUnits.vmax, "vmax")]
        [TestCase(CssUnits.vmin, "vmin")]
        public void ToCssString(CssUnits unit, string expected)
        {
            unit.ToCssString().Should().Be(expected);
        }
    }
}
