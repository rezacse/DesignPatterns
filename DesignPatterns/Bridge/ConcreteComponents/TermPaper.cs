using Bridge.Abstraction;
using Bridge.Implementor;
using System;

namespace Bridge.ConcreteComponents
{
    public class TermPaper : Manuscript
    {
        public string Class { get; set; }
        public string Student { get; set; }
        public string Text { get; set; }
        public string References { get; set; }

        public TermPaper(IFormatter formatter)
            : base(formatter)
        {
        }


        public override void Print()
        {
            Console.WriteLine(Formatter.Format("Class", Class));
            Console.WriteLine(Formatter.Format("Student", Student));
            Console.WriteLine(Formatter.Format("Text", Text));
            Console.WriteLine(Formatter.Format("References", References));

            Console.WriteLine("---------------------------------");
        }
    }
}
