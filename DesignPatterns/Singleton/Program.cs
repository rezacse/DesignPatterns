// See https://aka.ms/new-console-template for more information
using Singleton;

Console.WriteLine("Hello, World!");


Parallel.Invoke(
    PrintCounterForFirst,
    PrintCounterForSecond
   );

Console.ReadLine();

static void PrintCounterForFirst()
{
    var firstObject = SingletonService.GetInstance;
    firstObject.PrintObjectCounter("Counter for first object");
}

static void PrintCounterForSecond()
{
    var secondObject = SingletonService.GetInstance;
    secondObject.PrintObjectCounter("Counter for first object");
}


//﻿using System;
//using System.Threading.Tasks;

//namespace Singleton
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            Parallel.Invoke(
//                PrintArgumentException,
//                PrintNullException
//            );
//            Console.ReadLine();
//        }


//        private static void PrintNullException()
//        {
//            try
//            {
//                throw new NullReferenceException();
//            }
//            catch (Exception exception)
//            {
//                ExceptionHandler.GetInstance.LogException(exception);
//            }
//        }

//        private static void PrintArgumentException()
//        {
//            try
//            {
//                throw new ArgumentException();
//            }
//            catch (Exception exception)
//            {
//                ExceptionHandler.GetInstance.LogException(exception);
//            }
//        }
//    }
//}
