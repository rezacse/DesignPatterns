using Flyweight.Flyweight;

namespace Flyweight.ConcreteFlyweight
{
    public class ContractEmployeeBonus : IEmployeeBonus
    {
        public double CalculateBonus(double salary)
        {
            //30% of salary
            return salary * 0.30;
        }
    }
}
