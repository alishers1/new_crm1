using System.Runtime.CompilerServices;
using Crm.Entities;
using Crm.Service;

Console.WriteLine("Enter command\nCreate Client - 1\nCreate Order - 2\n");
int cmd = int.Parse(Console.ReadLine());


ClientService clientService = new();
OrderService orderService = new();

if (cmd == 1)
{
    CreateClient();
}
else 
{
    CreateOrder();
}

void CreateClient() 
{
    Console.Write("Enter your FirstName: ");
    string? firstName = Console.ReadLine();
    Console.Write("Enter your LastName: ");
    string? lastName = Console.ReadLine();
    Console.Write("Enter your MiddleName: ");
    string? middleName = Console.ReadLine();
    Console.Write("Enter your Age: ");
    short age = short.Parse(Console.ReadLine());
    Console.Write("Enter your Passport Number: ");
    string? passportNumber = Console.ReadLine();
    Console.Write("Enter your Gender (Male or Female): ");
    string? input = Console.ReadLine();
    Gender gender;
    if (Enum.TryParse(input, out gender))
    {
    }

    ClientInfo clientInfo = new(
        firstName,
        lastName,
        middleName,
        age,
        passportNumber,
        gender
    );

    Client newClient = clientService.CreateClient(clientInfo);

    Console.WriteLine(newClient.ToString());
}

void CreateOrder()
{
    Console.Write("Enter order Id: ");
    long id = long.Parse(Console.ReadLine());
    Console.Write("Enter order description: ");
    string? description = Console.ReadLine();
    Console.Write("Enter order price: ");
    double price = double.Parse(Console.ReadLine());
    Console.Write("Enter order date: ");
    DateTime date = DateTime.Parse(Console.ReadLine());
    Console.Write("Enter order delivery type (Express, Free, Standart): ");
    DeliveryType delivery = (DeliveryType) int.Parse(Console.ReadLine());
    Console.Write("Enter order address: ");
    string? address = Console.ReadLine();

    OrderInfo orderInfo = new(
        id,
        description,
        price,
        date,
        delivery,
        address
    );

    Order newOrder = orderService.CreateOrder(orderInfo);

    Console.WriteLine(orderInfo.ToString());
}