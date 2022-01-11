using Xunit;

namespace Demo.Tests
{
    public class AssertNumbersTests
    {
        [Fact]
        public void Calculator_Addition_MustBeEquals()
        {
            //Arrange

            var calculator = new Calculator();

            //Act   
            var result = calculator.Addition(3, 2);

            Assert.Equal(expected: 5, actual: result);
        }

        [Fact]
        public void Calculator_Addition_MustNotBeEquals()
        {
            //Arrange

            var calculator = new Calculator();

            //Act   
            var result = calculator.Addition(3.131331313331, 2.87643263);

            Assert.NotEqual(expected: 5.9, actual: result, precision:1);
        }

    }
}
