using Crm.Entities;
namespace Crm.Service; 

public sealed class OrderService
{
    private List<Order> _orders = new();
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

        _orders.Add(newOrder);

        return newOrder;
    }

    public Order GetOrderByDescription(string description)
    {
        return _orders.FirstOrDefault(order => order.Description == description);
    }

    public Order GetOrderById(long id)
    {
        return _orders.FirstOrDefault(order => order.Id == id);
    }
}