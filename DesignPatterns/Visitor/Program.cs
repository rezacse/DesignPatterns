using System;
using Visitor.ConcreteElement;
using Visitor.ConcreteVisitor;
using Visitor.ObjectStructure;

namespace Visitor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var employees = new Employees();


            employees.Attach(new Clerk("Clerk", 500, 15));
            employees.Attach(new Manager("Manager", 5000, 25));


            employees.Accept(new IncomeVisitor());
            employees.Accept(new VacationVisitor());


            Console.ReadKey();
        }
    }
}
