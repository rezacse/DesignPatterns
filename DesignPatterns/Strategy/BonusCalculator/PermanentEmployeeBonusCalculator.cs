using Strategy.Models;

namespace Strategy.BonusCalculator
{
    public class PermanentEmployeeBonusCalculator : IEmployeeBonusCalculator
    {
        public double CalculateBonus(Employee employee)
        {
            // 50% of salary
            return employee.Salary * 0.50;
        }
    }
}