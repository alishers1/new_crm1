namespace Crm.Entities;

public sealed class Client 
{
    private string? _firstname;
    private string? _lastName; 
    private string? _phone;
    private string? _email;
    private string? _password;
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
    public string? MiddleName { get; init; }
    public short Age { 
        get => _age; 
        init => _age = value > 18 ? value : throw new ArgumentException("Age is lower than 18!"); 
    }
    public string? Phone { 
        get => _phone ?? string.Empty; 
        init
        {
            if (!string.IsNullOrEmpty(value) && value.Length <= 9 && value.All(char.IsDigit))
            {
                _phone = value;
            }
            else 
            {
                throw new ArgumentException("Phone number must be a non-empty string of up to 9 digits");
            }
        }
    }
    public string? Email {
        get => _email ?? string.Empty;
        init => _email = value is { Length: > 0} ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    public string? Password {
        get => _password ?? string.Empty;
        init => _password = value is {Length: > 0} ? value : throw new ArgumentOutOfRangeException(nameof(value));
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