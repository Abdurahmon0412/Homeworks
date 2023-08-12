using N23_HT2;


var Users = new List<User>
{
    new User("John", "Doe", "johndoe@example.com"),
    new User("Jane", "Doe", "janedoe@example.com"),
    new User("Bob", "Smith", "bobsmith@example.com"),
    new User("Alice", "Johnson", "alicejohnson@example.com"),
    new User("Mike", "Brown", "mikebrown@example.com"),
    new User("Emily", "Davis", "emilydavis@example.com"),
    new User("David", "Wilson", "davidwilson@example.com"),
    new User("Sarah", "Taylor", "sarahtaylor@example.com"),
    new User("Tom", "Anderson", "tomanderson@example.com"),
    new User("Lisa", "Thomas", "lisathomas@example.com")
};

Console.WriteLine("Enter the keyword");
var keyvord = Console.ReadLine();

Users.Where(user => user.FirstName.Contains(keyvord, StringComparison.OrdinalIgnoreCase)
|| user.LastName.Contains(keyvord, StringComparison.OrdinalIgnoreCase) 
|| user.EmailAddress.Contains(keyvord, StringComparison.OrdinalIgnoreCase)).ToList()
.ForEach(user => 
Console.WriteLine($"{user.FirstName.PadRight(15)} {user.LastName.PadRight(15)} - {user.EmailAddress}"));


