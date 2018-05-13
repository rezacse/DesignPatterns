using System;
using System.Threading.Tasks;

namespace Singleton
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Parallel.Invoke(
                PrintArgumentException,
                PrintNullException
            );
            Console.ReadLine();
        }


        private static void PrintNullException()
        {
            try
            {
                throw new NullReferenceException();
            }
            catch (Exception exception)
            {
                ExceptionHandler.GetInstance.LogException(exception);
            }
        }

        private static void PrintArgumentException()
        {
            try
            {
                throw new ArgumentException();
            }
            catch (Exception exception)
            {
                ExceptionHandler.GetInstance.LogException(exception);
            }
        }
    }
}
