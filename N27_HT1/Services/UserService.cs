using System.Text.RegularExpressions;
using N27_HT1.Models;

namespace N27_HT1.Services;

public class UserService
{
    private List<User> _users;

    public UserService()
    {
        _users = new List<User>
        {
            new User("eshmat2@gmail.com", "eshmat747"),
            new User("toshmurodovj@.gmail.com", "fedya2232"),
            new User("muminow04gmail", "muhiddinov94")
        };
        EnsureAdminExists(_users);
    
    }

    public void Add(string email, string password)
    {
        const string regexEmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        Regex regex = new Regex(regexEmail);
        if (!regex.IsMatch(email) || string.IsNullOrWhiteSpace(email))
            throw new ArgumentException("Invalid email");
        const string regexPassword = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$";
        Regex regexpassword = new Regex(regexPassword);
        if(!regexpassword.IsMatch(password) || string.IsNullOrWhiteSpace(password))
            throw new ArgumentException("Invalid password");
        _users.Add(new User(email, password));
    }

    public List<User> GetUsers()
    {
        return _users;
    }

    private void EnsureAdminExists(List<User> users)
    {
        if (_users.Any(user => user.IsAdmin == true))
            return;
        if (!_users.Any(user => user.IsAdmin == true))
            _users.Prepend(new User("abdurahmonsadriddinov0412@gamil.com","Abdurahmon0412",true));
    }
}