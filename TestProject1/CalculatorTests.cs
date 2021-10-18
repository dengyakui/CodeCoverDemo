using CoveCoverDemo;
using Xunit;

namespace TestProject1
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator = new();

        [Theory]
        [InlineData(1, 2, 1)]
        [InlineData(0, 2, 2)]
        [InlineData(2, 2, 0)]
        public void Test_Add(int one, int two, int expected)
        {
            var actual = _calculator.Add(one, two);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_Subtract()
        {
            var one = 1;
            var two = 2;
            var actual = _calculator.Subtract(one, two);
            Assert.Equal(-1, actual);
        }
    }
}