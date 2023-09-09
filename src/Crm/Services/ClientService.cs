using Crm.Entities;
namespace Crm.Service;

public sealed class ClientService 
{
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
        return newClient;
    }
}