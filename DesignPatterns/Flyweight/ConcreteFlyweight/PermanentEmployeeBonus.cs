using Flyweight.Flyweight;

namespace Flyweight.ConcreteFlyweight
{
    public class PermanentEmployeeBonus : IEmployeeBonus
    {
        public double CalculateBonus(double salary)
        {
            //50% of bonus
            return salary * 0.50;
        }
    }
}
