using HT12_1;

var user1 = new User("aziz laziz gani");

var user2 = new User("aziz laziz gani");
Console.WriteLine (user1.FullName);
Console.WriteLine( user2.FullName);
Console.WriteLine(user2.Equals(user1));