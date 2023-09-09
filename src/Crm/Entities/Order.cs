namespace Crm.Entities; 

public sealed class Order 
{
    public long Id { get; set; }
    public string? Description { get; set; }
    public double Price { get; set; }
    public DateTime Date { get; set; }
    public DeliveryType Delivery { get; set; }
    public string? Address { get; set; }
}