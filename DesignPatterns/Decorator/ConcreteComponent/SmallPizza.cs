using Decorator.BookDecorate;
using Decorator.Component;

namespace Decorator.ConcreteComponent
{
    public class SmallPizza : Pizza
    {
        public override string GetDescription()
        {
            return Constants.SmallPizzaDescription;
        }

        public override double GetPrice()
        {
            return Constants.SmallPizzaPrice;
        }
    }
}
