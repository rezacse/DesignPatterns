using Strategy.Models;
using System;

namespace Strategy.BonusCalculator
{
    public class EmployeeSalaryCalculatorService
    {
        private readonly IEmployeeBonusCalculator _employeeBonusCalculator;

        public EmployeeSalaryCalculatorService(IEmployeeBonusCalculator employeeBonusCalculator)
        {
            _employeeBonusCalculator = employeeBonusCalculator;
        }

        public double CalculateSalary(Employee employee)
        {
            return employee.Salary + _employeeBonusCalculator.CalculateBonus(employee);
        }



        public EmployeeSalaryCalculatorService()
        {

        }

        public double CalculateSalary(Employee employee, Func<Employee, double> bonusStrategy)
        {
            return employee.Salary + bonusStrategy(employee);
        }

    }
}
