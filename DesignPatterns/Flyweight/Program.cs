using Flyweight.FlyweightFactory;
using System;

namespace Flyweight
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var employeeBonusFactory = EmployeeBonusFactory.GetInstance;
            Console.WriteLine("Permanent Employee Bonus");
            Console.WriteLine("---------------------------------------------------------------");
            for (var i = 1; i <= 5; i++)
            {
                var employeeBonus = employeeBonusFactory.GetEmployeeBonusObject("Permanent");
                var salary = 1000 * i;
                Console.WriteLine($"Salary: {salary} and Bonus: {employeeBonus.CalculateBonus(salary)}");
            }
            Console.WriteLine("---------------------------------------------------------------\n");

            Console.WriteLine("Contract Employee Bonus");
            Console.WriteLine("---------------------------------------------------------------");
            for (var i = 1; i <= 5; i++)
            {
                var employeeBonus = employeeBonusFactory.GetEmployeeBonusObject("Contract");
                var salary = 1000 * i;
                Console.WriteLine($"Salary: {salary} and Bonus: {employeeBonus.CalculateBonus(salary)}");
            }
            Console.WriteLine("---------------------------------------------------------------\n");

            Console.WriteLine($"Total object created: {employeeBonusFactory.TotalObject}");

            Console.ReadKey();
        }
    }
}
