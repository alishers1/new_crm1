using Crm.Entities;
using Crm.Interfaces;
namespace Crm.Service; 

public sealed class OrderService : OrderServiceBase
{
    public override Order CreateOrder(OrderInfo orderInfo)
    {
        Order newOrder = new(orderInfo.Description)
        {
            Id = orderInfo.Id,
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

    public Order ChangeOrderDescription(long id, string newDescription)
    {
        Order newOrder = _orders.FirstOrDefault(order => order.Id == id);

        if (newOrder != null)
        {
            newOrder = new Order(newDescription)
            {
                Id = newOrder.Id,
                Price = newOrder.Id,
                Date = newOrder.Date,
                Delivery = newOrder.Delivery,
                Address = newOrder.Address
            };

            int index = _orders.FindIndex(order => order.Id == id);
            if (index >= 0)
            {
                _orders[index] = newOrder;
            }
        }

        return newOrder;
    }

    public void DeleteOrderById(long id)
    {
        int index = _orders.FindIndex(order => order.Id == id);

        if (index >= 0)
        {
            _orders.RemoveAt(index);
        }
        else
        {
            throw new ArgumentException($"Order with ID {id} not found");
        }
    }
}