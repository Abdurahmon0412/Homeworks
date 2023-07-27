using HT12_1;
var user1 = new User();
var user2 = new User();
user1.Name = "alisher";
user1.Firstname = "gofurov";
user1.Lastname = "john";

user2.Name = "alisher";
user2.Firstname = "gofurov";
user2.Lastname = "john";

Console.WriteLine (user1.FullName);
Console.WriteLine( user2.FullName);
Console.WriteLine(user2.Equals(user1));