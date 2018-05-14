using Strategy.Models;
using System;

namespace Strategy.Factories
{
    public class EmployeeBonusDelegateFactory
    {
        public Func<Employee, double> GetEmployeeDelegate(Employee employee)
        {
            Func<Employee, double> employeeBonusDelegate;
            switch (employee.EmployeeType)
            {
                case EmployeeType.Contract:
                    employeeBonusDelegate = emp => employee.Salary * 0.30; ;
                    break;

                case EmployeeType.Permanent:
                    employeeBonusDelegate = emp => employee.Salary * 0.50;
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(employee), employee, null);
            }
            return employeeBonusDelegate;
        }
    }
}
