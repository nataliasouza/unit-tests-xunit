using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Demo.Tests
{
    public class AssertObjectTypesTests
    {
        public object FuncionarioFactory { get; private set; }

        [Fact]
        public void EmployeeFactory_Creat_MustReturnType_Employee()
        {
            //Arrange and Act
            var employee = EmployeeFactory.Creat(name:"Natalia", salary:10000);

            //Assert
            Assert.IsType<Employee>(employee);
        }

        [Fact]
        public void EmployeeFactory_Creat_MustReturnType_PeopleDetivative()
        {
            //Arrange and Act
            var employee = EmployeeFactory.Creat(name: "Natalia", salary: 10000);

            //Assert
            Assert.IsAssignableFrom<People>(employee);
        }
    }
}
