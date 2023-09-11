using System.Data.Common;

namespace Crm.Entities;

public readonly struct OrderInfo
{
    public readonly long Id { get; init; }
    public readonly string Description { get; init; }
    public readonly double Price { get; init; }
    public readonly DateTime Date { get; init; }
    public readonly DeliveryType Delivery { get; init; }
    public readonly string Address { get; init; }

    public OrderInfo(
        long id,
        string description,
        double price, 
        DateTime date,
        DeliveryType delivery,
        string address
    )
    {
        Id = id;
        Description = description;
        Price = price;
        Date = date;
        Delivery = delivery;
        Address = address;
    }
}