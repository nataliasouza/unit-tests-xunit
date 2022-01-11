using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Demo.Tests
{
    public class AssertRangesTests
    {
        [Theory]
        [InlineData(700)]
        [InlineData(1500)]
        [InlineData(2000)]
        [InlineData(7500)]
        [InlineData(8000)]
        [InlineData(15000)]

        public void Employee_Salary_SalaryRangesMustRespectProfessionalLevel(double salary)
        {
            //Arrange and Act
            var employee = new Employee(name: "Natalia", salary);

            //Assert

            if (employee.ProfessionalLevel == Enums.ProfessionalLevel.Estagiario)
                Assert.InRange(actual: employee.Salary, low: 1000, high: 2000);
            
            if (employee.ProfessionalLevel == Enums.ProfessionalLevel.Junior)
                Assert.InRange(actual: employee.Salary, low: 2200, high: 5000);

            if (employee.ProfessionalLevel == Enums.ProfessionalLevel.Pleno)
                Assert.InRange(actual: employee.Salary, low: 5200, high: 8000);

            if (employee.ProfessionalLevel == Enums.ProfessionalLevel.Senior)
                Assert.InRange(actual: employee.Salary, low: 8200, high: double.MaxValue);

            Assert.NotInRange(actual: employee.Salary, low: 0, high: 999);
        }
    }
}
