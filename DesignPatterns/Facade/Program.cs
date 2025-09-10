using Facade.SubSystem;
using System;

namespace Facade
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Facade
            var loanEligibilityChecker = new LoanEligibilityChecker();

            var student = new Student("James Bond");
            double loanAmount = 12000;
            var isEligible = loanEligibilityChecker.IsEligibleForLoan(student, loanAmount);

            Console.WriteLine($"\n{student.Name} has been " + (isEligible ? "Approved" : "Rejected"));

            Console.ReadKey();
        }
    }
}
