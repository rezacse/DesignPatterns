namespace Proxy.LazyLoad.Repositories
{
    //public class RemoteRepository : Repository<OrderEntity>
    //{
    //    public override OrderEntity GetById(int id)
    //    {
    //        Console.WriteLine("--> Using WCF to Fetch Order " + id);
    //        var dto =
    //            new OrderService.OrderServiceClient().GetDataUsingDataContract(id);
    //        return new OrderEntity()
    //        {
    //            Id = dto.Id,
    //            CustomerId = dto.CustomerId,
    //            OrderDetails = dto.OrderItems,
    //            OrderDate = dto.OrderDate
    //        };
    //    }
    //}
}
