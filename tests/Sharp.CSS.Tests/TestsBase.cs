using FluentAssertions;

namespace Sharp.CSS.Tests
{
    public class TestsBase<T>
    {
        protected void VerifyValue(T obj, string expected)
        {
            obj.ToString().Should().Be(expected);
        }
    }
}
