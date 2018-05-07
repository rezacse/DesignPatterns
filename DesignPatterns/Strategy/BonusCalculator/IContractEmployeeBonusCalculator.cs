using Strategy.Models;

namespace Strategy.BonusCalculator
{
    public class ContractEmployeeBonusCalculator : IEmployeeBonusCalculator
    {
        public double CalculateBonus(Employee employee)
        {
            // 30% of salary
            return employee.Salary * 0.30;
        }
    }
}
