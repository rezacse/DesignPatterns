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