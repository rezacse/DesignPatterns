using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class SingletonService
    {

        //to check object creation
        private readonly int _counter;
        private SingletonService()
        {
            Console.WriteLine("mumber of instance created : " + ++_counter);
        }


        // lazy initialization for thread safety    
        private static readonly object Obj = new object();
        private static SingletonService _instance;
        public static SingletonService GetInstance
        {
            get
            {
                //double check
                if (_instance != null)
                    return _instance;

                lock (Obj)
                {
                    if (_instance == null)
                        _instance = new SingletonService();
                }

                return _instance;
            }
        }


        //// eger initailization 
        //public static Singleton GetInstance { get; } = new Singleton();


        ////lazy initialization with Lazy  
        //private static readonly Lazy<Singleton> _instance = new Lazy<Singleton>(() => new Singleton());
        //public static Singleton GetInstance => _instance.Value;

        public void PrintObjectCounter(string message)
        {
            Console.WriteLine(message + ": " + _counter);
        }

    }
}
