using Decorator.Component;

namespace Decorator.ConcreteComponent
{
    public class LargePizza : Pizza
    {
        public override string GetDescription()
        {
            return Constants.LargePizzaDescription;
        }

        public override double GetPrice()
        {
            return Constants.LargePizzaPrice;
        }
    }
}
