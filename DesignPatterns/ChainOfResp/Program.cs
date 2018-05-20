using ChainOfResp.ConcreteHandler;
using ChainOfResp.Handler;
using ChainOfResp.Utilities;
using System;

namespace ChainOfResp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Approver ronny = new Manager();
            Approver mony = new Director();
            Approver poly = new President();


            ronny.SetSuccessor(mony);
            mony.SetSuccessor(poly);

            var purchase = new Purchase(1, "Apple", 500);
            ronny.ProcessRequest(purchase);

            purchase = new Purchase(2, "Mango", 4500);
            ronny.ProcessRequest(purchase);

            purchase = new Purchase(3, "Gold", 9500);
            ronny.ProcessRequest(purchase);



            Console.ReadKey();
        }
    }
}
