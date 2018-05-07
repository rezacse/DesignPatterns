using Decorator.Component;
using Decorator.ConcreteComponent;
using Decorator.ConcreteDecorator;
using System;

namespace Decorator
{
    public class Program
    {
        private static void Main()
        {

            Pizza largePizza = new LargePizza();
            largePizza = new Cheese(largePizza);
            largePizza = new Ham(largePizza);
            largePizza = new Peppers(largePizza);


            Console.WriteLine($"Pizza Description: {largePizza.GetDescription()}");
            Console.WriteLine($"Pizza Price: {largePizza.GetPrice()}");

            Console.ReadKey();
        }
    }
}
