using Xunit;

namespace Demo.Tests
{
    public class AssertNullBoolTests
    {
        [Fact]
        public void Employee_Name_NotNullOrEmpty()
        {
            //Arrange and Act
            var employee = new Employee(name: "", salary: 4000);

            //Assert
            Assert.False(string.IsNullOrEmpty(employee.Name));
        }
        
        [Fact]
        public void Employee_Surname_NotHaveSurname()
        {
            //Arrange and Act
            var employee = new Employee(name:"Natalia", salary: 4000);

            //Assert
            Assert.Null(employee.Surname);

            //Assert boll
            Assert.True(string.IsNullOrEmpty(employee.Surname));
            Assert.False(condition: employee.Surname?.Length > 0);
        }
    }
}
