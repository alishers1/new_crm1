namespace Crm.Entities; 

public sealed class Order 
{
    private string? _description; 
    private double _price;
    private DeliveryType _delivery; 



    public long Id { get; init; }
    public string? Description { 
        get => _description ?? string.Empty; 
        init => _description = value is { Length: > 0} ? value : throw new ArgumentException("Description can't be empty"); 
    }
    public double Price { 
        get => _price; 
        init => _price = value > 0 ? value : throw new ArgumentException("Price can't be negative"); 
    }
    public DateTime Date { get; set; }
    public DeliveryType Delivery { 
        get => _delivery; 
        init
        {
            if (value == DeliveryType.Express || value == DeliveryType.Free || value == DeliveryType.Standart)
            {
                _delivery = value;
            }
            else 
            {
                throw new ArgumentException("Delivery Type can be only Free, Standart or Express");
            }
        }
    }
    public string? Address { get; init; }

    public OrderState State { get; init; }

    public Order(string description)
    {
        Description = description;
    }

    public Order(OrderState newState)
    {
        State = newState;
    }

    public override string ToString()
    {
        return $"Order Id: {Id}\n"+
               $"Order description: {Description}\n" +
               $"Order price and delivery type: {Price} {Delivery}\n" +
               $"Order address: {Address}\n";
    }
}