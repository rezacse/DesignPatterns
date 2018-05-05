using FactoryMethod.Factory.FactoryMethods;
using FactoryMethod.Models;
using System;

namespace FactoryMethod.Factory
{
    public class EmployeeManagerFactory
    {
        public BaseEmployeeFactory GetEmployeeManager(Employee employee)
        {
            BaseEmployeeFactory employeeFactory;
            switch (employee.EmployeeType)
            {
                case EmployeeType.Contract:
                    employeeFactory = new ContractEmployeeFactory(employee);
                    break;
                case EmployeeType.Permanent:
                    employeeFactory = new PermanentEmployeeFactory(employee);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(employee), employee, null);
            }

            return employeeFactory;
        }
    }
}
