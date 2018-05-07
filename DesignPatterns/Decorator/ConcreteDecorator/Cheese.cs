using Decorator.Component;
using Decorator.Decorator;

namespace Decorator.ConcreteDecorator
{
    public class Cheese : PizzaDecorator
    {

        public Cheese(Pizza pizza)
            : base(pizza)
        {
        }

        public override string GetDescription()
        {
            return Pizza.GetDescription() + ", " + Constants.CheeseDescription;
        }

        public override double GetPrice()
        {
            return Pizza.GetPrice() + Constants.CheesePrice;
        }
    }
}
