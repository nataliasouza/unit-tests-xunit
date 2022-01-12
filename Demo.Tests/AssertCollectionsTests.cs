using Xunit;

namespace Demo.Tests
{
    public class AssertCollectionsTests
    {
        [Fact]
        public void Employee_Skills_MustNotPossess_EmptySkills()
        {
            //Arrange and Act
            var employee = EmployeeFactory.Creat(name: "Natt", salary: 10000);

            //Assert
            Assert.All(employee.Skills, action: skill => Assert.False(string.IsNullOrWhiteSpace(skill)));
        }

        [Fact]
        public void Employee_Skills_JuniorMustHave_BasicSkill()
        {
            //Arrange and Act
            var employee = EmployeeFactory.Creat(name: "Natt", salary: 4000);

            //Assert
            Assert.Contains(expected: "OOP", employee.Skills);
        }

        [Fact]
        public void Employee_Skills_JuniorMustNotHave_AdvancedSkill()
        {
            //Arrange and Act
            var employee = EmployeeFactory.Creat(name: "Natt", salary: 4000);

            //Assert
            Assert.DoesNotContain(expected: "Microservices", employee.Skills);
        }

        [Fact]
        public void Employee_Skills_Senior_MustPossessAllSkills()
        {
            //Arrange and act
            var employee = EmployeeFactory.Creat(name: "Natt", salary: 15000);

            var skillsBasics = new[]
            {
                "Lógica de Programação",
                "OOP",
                "Testes",
                "Microservices"
            };

            //Assert
            Assert.Equal(expected: skillsBasics, actual: employee.Skills);
        }
    }
}
