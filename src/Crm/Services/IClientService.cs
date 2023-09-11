using Crm.Entities;

namespace Crm.Interfaces;

public interface IClientService
{
    Client CreateClient(ClientInfo clientInfo);
    Client GetClientByFirstAndLastName(string firstName, string lastName);
}

public abstract class ClientServiceBase
{
    protected List<Client> _clients = new();
    public abstract Client CreateClient(ClientInfo clientInfo);
    public abstract Client GetClientByFirstAndLastName(string firstName, string lastName);
}