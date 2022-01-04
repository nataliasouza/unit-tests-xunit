using Xunit;

namespace Demo.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Calculator_Addition_ReturnSumValue()
        {
            //Arrange
            var calculador = new Calculator();

            //Act

            var result = calculador.Addition(2,2);

            //Assert
            Assert.Equal(expected: 4, actual: result);
        }

        [Theory]
        [InlineData(1,1,2)]
        [InlineData(5,3,8)]
        [InlineData(2,8,10)]
        public void Calculator_Addition_ReturnSumValueValid(double n1, double n2, double total)
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Addition(n1, n2);

            //Assert
            Assert.Equal(expected: total, actual: result);
        }
    }
}
