using System.Data.Common;
using System.Runtime.CompilerServices;
using Crm.Entities;
using Crm.Interfaces;
namespace Crm.Service;

public sealed class ClientService : IClientService
{
    private ulong _id = 0;
    private List<Client> _clients = new();

    public Client CreateClient(ClientInfo clientInfo)
    {
        Client newClient = new(clientInfo.FirstName, clientInfo.LastName)
        {
            Id = _id++,
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

    public Client ChangeClientFirstAndLastName(ulong clientId, string newFirstName, string newLastName)
    {
        Client foundedClient = _clients.FirstOrDefault(client => client.Id == clientId);
        
        if (foundedClient != null)
        {
            foundedClient = new Client(newFirstName, newLastName)
            {
                Id = foundedClient.Id,
                MiddleName = foundedClient.MiddleName,
                Age = foundedClient.Age,
                PassportNumber = foundedClient.PassportNumber,
                Gender = foundedClient.Gender
            };

            int index = _clients.FindIndex(client => client.Id == clientId);
            if (index >= 0)
            {
                _clients[index] = foundedClient;
            }
        }

        return foundedClient;
    }

    public void RemoveClientById(ulong id)
    {
        int index = _clients.FindIndex(client => client.Id == id);
        
        if (index >= 0)
        {
            _clients.RemoveAt(index);
        }
        else
        {
            throw new ArgumentException($"Client with id - {id} not found");
        }
    }
}