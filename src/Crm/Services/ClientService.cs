using System.Runtime.CompilerServices;
using Crm.Entities;
using Crm.Interfaces;
namespace Crm.Service;

public sealed class ClientService : IClientService
{
    private List<Client> _clients = new();

    public Client CreateClient(ClientInfo clientInfo)
    {
        Client newClient = new()
        {
            FirstName = clientInfo.FirstName,
            LastName = clientInfo.LastName, 
            MiddleName = clientInfo.MiddleName,
            Age = clientInfo.Age, 
            PassportNumber = clientInfo.PassportNumber, 
            Gender = clientInfo.Gender
        };

        _clients.Add(newClient);

        return newClient;
    }

    public Client GetClientByFirstAndLastName(string firstName, string lastName)
    {
        return _clients.FirstOrDefault(client => client.FirstName == firstName && client.LastName == lastName);
    }
}