using Crm.Entities;

namespace Crm.Interfaces;

public interface IOrderService
{
    Order CreateOrder(OrderInfo orderInfo);
    Order GetOrderByDescription(string description);
    Order GetOrderById(long id);
}

public abstract class OrderServiceBase 
{
    protected List<Order> _orders = new();

    public abstract Order CreateOrder(OrderInfo orderInfo);
    public abstract Order GetOrderByDescription(string description);
    public abstract Order GetOrderById(long id);
}

