using Strategy.Models;

namespace Strategy.BonusCalculator
{
    public interface IEmployeeBonusCalculator
    {
        double CalculateBonus(Employee employee);
    }
}