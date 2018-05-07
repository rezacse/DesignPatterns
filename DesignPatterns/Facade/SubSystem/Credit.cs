using System;

namespace Facade.SubSystem
{
    public class Credit
    {
        public bool HasGoodCredits(Student student)
        {
            //TODO add logic to check good credit
            Console.WriteLine($"Verify credit for {student.Name}");
            return true;
        }
    }
}
