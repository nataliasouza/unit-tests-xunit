namespace Demo
{
    public class EmployeeFactory
    {
        public static Employee Creat(string name, double salary)
        {
            return new Employee(name, salary);
        }
    }
}
