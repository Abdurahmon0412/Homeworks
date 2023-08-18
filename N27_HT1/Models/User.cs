namespace N27_HT1.Models;

public class User
{
    public Guid Id { get; set; }
    string EmailAddress { get; set; }
    public string Password { get; set; }
    public bool IsAdmin { get; set; }

    public User()
    {
        
    }

    public User(string emailAddress, string password, bool isAdmin = false)
    {
        Id = Guid.NewGuid();
        EmailAddress = emailAddress;
        Password = password;
        IsAdmin = isAdmin;
    }

    public override string ToString()
    {
        return $"Email: {EmailAddress}password: ******";
    }
}