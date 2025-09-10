using System;
using System.Collections.Generic;
using Visitor.ConcreteElement;
using Visitor.Visitor;

namespace Visitor.ObjectStructure
{
    public class Employees
    {
        private readonly List<Employee> _employees = new List<Employee>();

        public void Attach(Employee employee)
        {
            _employees.Add(employee);
        }

        public void Detach(Employee employee)
        {
            if (_employees.Contains(employee))
                _employees.Remove(employee);
        }

        public void Accept(IVisitor visitor)
        {
            Console.WriteLine($"\n{visitor.GetType().Name}\n-----------------------------------");
            foreach (var employee in _employees)
            {
                employee.Accept(visitor);
            }

        }
    }
}
