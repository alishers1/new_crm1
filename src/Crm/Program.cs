using System.Runtime.CompilerServices;
using Crm.Entities;
using Crm.Service;

ClientService clientService = new();
OrderService orderService = new();

while (true) 
{
    Console.WriteLine("Enter command\nCreate Client - 1\nCreate Order - 2\nFind client - 3\n"+
    "Find Order by description - 4\nFind order by id - 5\nChange client first and last name - 6\n");
    int cmd = int.Parse(Console.ReadLine());

    if (cmd == 1)
    {
        CreateClient();
    }
    else if (cmd == 2) 
    {
        CreateOrder();
    }
    else if (cmd == 3)
    {
        FindClient();
    }
    else if (cmd == 4)
    {
        GetOrderByDescription();
    }
    else if (cmd == 5)
    {
        GetOrderById();
    }
    else {
        Console.WriteLine("Invalid command");
    }
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

void FindClient()
{
    Console.WriteLine("Enter client firstname: ");
    string? firstName = Console.ReadLine();
    Console.WriteLine("Enter client lastname: ");
    string? lastName = Console.ReadLine();


    Client foundClient = clientService.GetClientByFirstAndLastName(firstName, lastName);
    if (foundClient != null)
    {
        Console.WriteLine(foundClient.ToString());
    }
    else {
        Console.WriteLine("Not found client with provided firstname and lastname");
    }
}

void GetOrderByDescription()
{
    Console.Write("Enter order description: ");
    string? description = Console.ReadLine();

    Order newOrder = orderService.GetOrderByDescription(description);
    if (newOrder != null)
    {
        Console.WriteLine("Found order: ", newOrder.ToString);
    } 
    else 
    {
        Console.WriteLine("Not found order");
    }
}

void GetOrderById()
{
    Console.Write("Enter order id: ");
    long id = long.Parse(Console.ReadLine());

    Order newOrder = orderService.GetOrderById(id);
    if (newOrder != null)
    {
        Console.WriteLine("Found order: ", newOrder.ToString);
    } 
    else 
    {
        Console.WriteLine("Not found order");
    }
}

void ChangeClientFirstAndLastName()
{
    Console.Write("Enter client id: ");
    ulong id = ulong.Parse(Console.ReadLine());
    Console.Write("Enter new client FirstName: ");
    string? newFirstName = Console.ReadLine();
    Console.Write("Enter new client LastName: ");
    string? newLastName = Console.ReadLine();

    Client client = clientService.ChangeClientFirstAndLastName(id, newFirstName, newLastName);

    Console.WriteLine(client.ToString());
}