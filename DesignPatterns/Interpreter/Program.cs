using Interpreter.AbstractExpressions;
using Interpreter.ConcreteExpressions;
using Interpreter.Contexts;
using System;
using System.Collections.Generic;

namespace Interpreter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const string roman = "MCMXXVIII";
            var context = new Context(roman);

            var interpreters = new List<AbstractInterpreter>
            {
                new ThousandInterpreter(),
                new HundredInterpreter(),
                new TenInterpreter(),
                new OneInterpreter()
            };


            foreach (var exp in interpreters)
            {
                exp.Interpret(context);
            }

            Console.WriteLine($"{roman} = {context.Output}");


            Console.ReadKey();
        }
    }
}
