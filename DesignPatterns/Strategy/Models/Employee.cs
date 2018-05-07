using FactoryMethod.Models;

namespace Strategy.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public EmployeeType EmployeeType { get; set; }
    }
}
