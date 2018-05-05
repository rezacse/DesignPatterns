using FactoryMethod.Factory;
using FactoryMethod.Models;

namespace FactoryMethod
{
    public class Program
    {
        private static void Main()
        {
            var employee = new Employee
            {
                EmployeeType = EmployeeType.Permanent
            };

            var factory = new EmployeeManagerFactory().GetEmployeeManager(employee);
            factory.ApplySalary();

            //
            employee = new Employee
            {
                EmployeeType = EmployeeType.Contract
            };
            factory = new EmployeeManagerFactory().GetEmployeeManager(employee);
            factory.ApplySalary();
        }
    }
}
