using Crm.Entities;
namespace Crm.Service;

public sealed class ClientService 
{
    public Client CreateClient(
        string firstName, 
        string lastName,
        string middleName, 
        short age, 
        string passportNumber,
        Gender gender
    )
    {
        return new()
        {
            FirstName = firstName,
            LastName = lastName, 
            MiddleName = middleName,
            Age = age, 
            PassportNumber = passportNumber, 
            Gender = gender
        };
    }
}