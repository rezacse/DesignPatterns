using Decorator.BookDecorate;
using Decorator.Component;
using Decorator.Decorator;

namespace Decorator.ConcreteDecorator
{
    public class Ham : PizzaDecorator
    {
        public Ham(Pizza pizza)
            : base(pizza)
        {
        }

        public override string GetDescription()
        {
            return Pizza.GetDescription() + ", " + Constants.HamDescription;
        }

        public override double GetPrice()
        {
            return Pizza.GetPrice() + Constants.HamPrice;
        }
    }
}
