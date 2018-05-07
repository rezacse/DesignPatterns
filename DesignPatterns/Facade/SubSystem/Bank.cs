using System;

namespace Facade.SubSystem
{
    public class Bank
    {
        public bool HasSufficientSavings(Student student, double amount)
        {
            //TODO add logic to check sufficient savings
            Console.WriteLine($"Verify sufficient savings for {student.Name}");
            return true;
        }
    }

}
