using Proxy.LazyLoad.Models;

namespace Proxy.LazyLoad.Proxy
{
    public class RemoteOrder : Order
    {
        public RemoteOrder(int id)
            : base(id)
        {

        }

        protected override void GetEntity()
        {
            //this.OrderEntity = new Re
        }
    }
}
