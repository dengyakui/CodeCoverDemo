using CoveCoverDemo;
using Xunit;

namespace TestProject1
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator = new();

        [Fact]
        public void Test_Add()
        {
            var one = 1;
            var two = 2;
            var actual = _calculator.Add(one, two);
            Assert.Equal(3, actual);
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