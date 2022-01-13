using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Demo.Tests
{
    public class AssertExceptionsTests
    {
        [Fact]
        public void Calculator_Division_ShouldReturnDivision_ByZeroError()
        {
            //Arrange
            var calculator = new Calculator();

            //Act and Assert
            Assert.Throws<DivideByZeroException>(testCode:()=> calculator.Division(10,0));
        }
        [Fact]
        public void Employee_Salary_ShouldReturnLower_Allowable_SalaryError()
        {
            //Arrange, Act and Assert
            var exception =
                Assert.Throws<Exception>(testCode:() => EmployeeFactory.Creat(name:"Natt", salary: 250));

            Assert.Equal(expected: "Salário inferior ao permitido", actual: exception.Message);
        }
    }
}
