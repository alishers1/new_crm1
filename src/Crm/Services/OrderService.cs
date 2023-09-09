using Crm.Entities;
using Crm.Interfaces;
namespace Crm.Service; 

public sealed class OrderService : OrderServiceBase
{
    public override Order CreateOrder(OrderInfo orderInfo)
    {
        Order newOrder = new()
        {
            Id = orderInfo.Id,
            Description = orderInfo.Description,
            Price = orderInfo.Price,
            Date = orderInfo.Date,
            Delivery = orderInfo.Delivery,
            Address = orderInfo.Address
        };

        _orders.Add(newOrder);

        return newOrder;
    }

    public  override Order GetOrderByDescription(string description)
    {
        return _orders.FirstOrDefault(order => order.Description == description);
    }

    public override Order GetOrderById(long id)
    {
        return _orders.FirstOrDefault(order => order.Id == id);
    }
}