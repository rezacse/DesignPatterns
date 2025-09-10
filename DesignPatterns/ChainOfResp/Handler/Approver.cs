using ChainOfResp.Utilities;

namespace ChainOfResp.Handler
{
    public abstract class Approver
    {
        protected Approver Successor;

        public void SetSuccessor(Approver approver)
        {
            Successor = approver;
        }

        public abstract void ProcessRequest(Purchase purchase);
    }
}
