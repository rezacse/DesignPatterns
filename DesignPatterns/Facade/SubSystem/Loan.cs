using System;

namespace Facade.SubSystem
{
    public class Loan
    {
        public bool HasNoBadLoans(Student student)
        {
            //TODO add logic to check bad loans
            Console.WriteLine($"Verify load for {student.Name}");
            return true;
        }
    }
}
