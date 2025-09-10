using System;
using Visitor.ConcreteElement;
using Visitor.Visitor;

namespace Visitor.ConcreteVisitor
{
    public class IncomeVisitor : IVisitor
    {
        public void Visit(Element.Element element)
        {
            if (!(element is Employee employee))
                return;

            // Provide 10% pay raise
            employee.Income *= 1.10;
            Console.WriteLine($"{employee.GetType().Name} {employee.Name}'s new income: {employee.Income}");
        }
    }
}
