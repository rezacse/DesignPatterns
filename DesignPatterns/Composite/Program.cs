using Composite.Composite;
using Composite.Leaf;
using System;

namespace Composite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var totalAmount = 3000;
            Console.WriteLine($"You have {totalAmount} dollars, divide it's among the existing groups");


            var brad = new Person { Name = "Brad Pitt" };
            var leonardo = new Person { Name = "Leonardo DiCaprio" };
            var tom = new Person { Name = "Tom Cruise" };

            var heros = new PersonGroup { GroupName = "Heros", Members = { brad, leonardo, tom } };

            var jolie = new Person { Name = "Angelina Jolie" };
            var kate = new Person { Name = "Kate Winslet" };
            var heroines = new PersonGroup { GroupName = "Heroines", Members = { jolie, kate } };

            var vallian = new Person { Name = "Boss" };

            var superstars = new PersonGroup { GroupName = "Super Star", Members = { heros, heroines, vallian } };
            superstars.Amount += totalAmount;
            superstars.PrintStatus();


            Console.ReadKey();
        }
    }
}
