using Visitor.Visitor;

namespace Visitor.ConcreteElement
{
    public class Employee : Element.Element
    {
        public string Name { get; set; }
        public double Income { get; set; }
        public int VacationDays { get; set; }

        protected Employee(string name, double income, int vacation)
        {
            Name = name;
            Income = income;
            VacationDays = vacation;
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
