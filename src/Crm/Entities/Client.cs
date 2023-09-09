namespace Crm.Entities;

public sealed class Client 
{
    private string? _firstname;
    private string? _lastName; 
    private short _age; 
    private Gender _gender;
 


    public string? FirstName { 
        get => _firstname ?? string.Empty; 
        init => _firstname = value is { Length: > 0} ? value : throw new ArgumentOutOfRangeException(nameof(value)); 
    }
    public string? LastName { 
        get => _lastName ?? string.Empty; 
        init => _lastName = value is {Length: > 0} ? value : throw new ArgumentOutOfRangeException(nameof(value)); 
    }
    public string? MiddleName { get; set; }
    public short Age { 
        get => _age; 
        init => _age = value > 18 ? value : throw new ArgumentException("Age is lower than 18!"); 
    }
    public string? PassportNumber { get; init; }
    public Gender Gender { 
       get => _gender;
       init 
       {
        if (value == Gender.Male || value == Gender.Female)
        {
            _gender = value;
        }
        else 
        {
            throw new ArgumentException("Gender must be Male or Female");
        }
       }
    }

    // public Client(string firstName, string lastName, short age)
    // {
    //     FirstName = firstName;
    //     LastName = lastName;
    //     Age = age;
    // }

    public override string ToString()
    {
        return $"Client Name: {FirstName} {LastName}\n" +
               $"Middle Name: {MiddleName}\n" +
               $"Age: {Age}\n" +
               $"Passport Number: {PassportNumber}\n" +
               $"Gender: {Gender}"; 
    }
}