using Crm.Entities;
namespace Crm.Service; 

public sealed class OrderService
{
    public Order CreateOrder(
        long id,
        string description, 
        double price,
        DateTime date,
        DeliveryType delivery,
        string address
    )
    {
        return new()
        {
            Id = id,
            Description = description,
            Price = price,
            Date = date,
            Delivery = delivery,
            Address = address
        };
    }
}