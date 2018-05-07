using Decorator.Component;
using Decorator.Decorator;

namespace Decorator.ConcreteDecorator
{
    public class Peppers : PizzaDecorator
    {
        public Peppers(Pizza pizza)
            : base(pizza)
        {
        }

        public override string GetDescription()
        {
            return Pizza.GetDescription() + ", " + Constants.PeppersDescription;
        }

        public override double GetPrice()
        {
            return Pizza.GetPrice() + Constants.PeppersPrice;
        }
    }
}
