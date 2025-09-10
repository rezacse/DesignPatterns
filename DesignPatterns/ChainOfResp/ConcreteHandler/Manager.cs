using ChainOfResp.Handler;
using ChainOfResp.Utilities;
using System;

namespace ChainOfResp.ConcreteHandler
{
    public class Manager : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Price <= ApproveLimit.Manager)
                Console.WriteLine($"{GetType().Name} approved request {purchase.Id} of TK. { purchase.Price}");
            else
                Successor?.ProcessRequest(purchase);
        }
    }
}
