using Decorator.BookDecorate;
using Decorator.Component;

namespace Decorator.ConcreteComponent
{
    public class MediumPizza : Pizza
    {
        public override string GetDescription()
        {
            return Constants.MediumPizzaDescription;
        }

        public override double GetPrice()
        {
            return Constants.MediumPizzaPrice;
        }
    }
}
