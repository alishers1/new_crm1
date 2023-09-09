using Crm.Entities;
namespace Crm.Service; 

public sealed class OrderService
{
    public Order CreateOrder(OrderInfo orderInfo)
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

        return newOrder;
    }
}