using Composite.Component;
using System;

namespace Composite.Leaf
{
    public class Person : IPerson
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public void PrintStatus()
        {
            Console.WriteLine($"{Name} has {Amount} Dollars");
        }
    }
}
