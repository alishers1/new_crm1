using System.Runtime.CompilerServices;
using Crm.Entities;
using Crm.Service;

ClientService clientService = new();
CreateClient();

OrderService orderService = new();

void CreateClient() 
{
    string? firstName = Console.ReadLine();
    string? lastName = Console.ReadLine();
    string? middleName = Console.ReadLine();
    short age = short.Parse(Console.ReadLine());
    string? passportNumber = Console.ReadLine();
    Gender gender = (Gender) int.Parse(Console.ReadLine());

    Client newClient = clientService.CreateClient(
        firstName,
        lastName, 
        middleName,
        age,
        passportNumber,
        gender
    );

    Console.WriteLine("Client Name: {0}", string.Join(' ', newClient.FirstName, newClient.MiddleName, newClient.LastName));
    Console.WriteLine("Client Age: {0}", newClient.Age);
    Console.WriteLine("Client passport number: {0}", newClient.PassportNumber);
}

void CreateOrder()
{
    long id = long.Parse(Console.ReadLine());
    string? description = Console.ReadLine();
    double price = double.Parse(Console.ReadLine());
    DateTime date = DateTime.Parse(Console.ReadLine());
    DeliveryType delivery = (DeliveryType) int.Parse(Console.ReadLine());
    string? address = Console.ReadLine();

    Order newOrder = orderService.CreateOrder(
        id,
        description,
        price,
        date,
        delivery,
        address
    );

    Console.WriteLine("Order Id: {0}", newOrder.Id);
    Console.WriteLine("Order Description: {0}", newOrder.Description);  
}