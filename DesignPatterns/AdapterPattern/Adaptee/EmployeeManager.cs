using System.Collections.Generic;

namespace AdapterPattern.Adaptee
{
    public class EmployeeManager
    {
        private List<Employee> Employees { get; }

        public EmployeeManager()
        {
            Employees = new List<Employee>
            {
                new Employee {Id = 1, Name = "Tamim Iqbal", Address = "Bangladesh"},
                new Employee {Id = 2, Name = "ABD", Address = "South Africa"},
                new Employee {Id = 3, Name = "Chris Gayle", Address = "West Indies"}
            };
        }

        public List<Employee> GetEmployees()
        {
            return Employees;
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
