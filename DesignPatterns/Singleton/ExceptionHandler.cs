using System;

namespace Singleton
{
    public sealed class ExceptionHandler
    {

        private static readonly Lazy<ExceptionHandler>
            Instance = new Lazy<ExceptionHandler>(() => new ExceptionHandler());

        private static int _counter;
        private ExceptionHandler()
        {
            _counter++;
            Console.WriteLine("Object counter: " + _counter);
        }

        public static ExceptionHandler GetInstance => Instance.Value;

        public void LogException(Exception exception)
        {
            Console.WriteLine("Exception: " + exception.Message + " at " + DateTime.Now);
        }
    }
}
