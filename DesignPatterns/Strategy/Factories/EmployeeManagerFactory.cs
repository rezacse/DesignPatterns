using FactoryMethod.Models;
using Strategy.BonusCalculator;
using Strategy.Models;
using System;

namespace Strategy.Factories
{
    public class EmployeeBonusManagerFactory
    {
        public IEmployeeBonusCalculator GetEmployeeManager(Employee employee)
        {
            IEmployeeBonusCalculator employeeBonusFactory;
            switch (employee.EmployeeType)
            {
                case EmployeeType.Contract:
                    employeeBonusFactory = new ContractEmployeeBonusCalculator();
                    break;
                case EmployeeType.Permanent:
                    employeeBonusFactory = new PermanentEmployeeBonusCalculator();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(employee), employee, null);
            }
            return employeeBonusFactory;
        }
    }
}
