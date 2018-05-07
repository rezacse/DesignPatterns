using Decorator.Component;

namespace Decorator.Decorator
{
    public class PizzaDecorator : Pizza
    {
        protected Pizza Pizza;

        public PizzaDecorator(Pizza pizza)
        {
            Pizza = pizza;
        }

        public override string GetDescription()
        {
            return Pizza.GetDescription();
        }

        public override double GetPrice()
        {
            return Pizza.GetPrice();
        }
    }
}
