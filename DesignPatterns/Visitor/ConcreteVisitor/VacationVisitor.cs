using System;
using Visitor.ConcreteElement;
using Visitor.Visitor;

namespace Visitor.ConcreteVisitor
{
    public class VacationVisitor : IVisitor
    {
        public void Visit(Element.Element element)
        {
            if (!(element is Employee employee))
                return;

            // Provide 3 extra vacation days
            employee.VacationDays += 3;
            Console.WriteLine(
                $"{employee.GetType().Name} {employee.Name}'s new vacation days: {employee.VacationDays}");
        }
    }
}
