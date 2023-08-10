using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imtihon_Update.Interfaces;
namespace Imtihon_Update
{
    public class User:IUser
    {
        //User modeli - foydalanuvchi ismi, familyasi, sharifi, email addresi, username va aktiv foydalanuvchi ekanligi haqidagi ma’lumotlarni saqlovchi model
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public bool IsActived { get; set; }

        public User() { }

        public User(string name, string firstName, string lastName, string email, string username)
        {
            Name = name;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Username = username;
        }

        public override string ToString()
        {
            return $"Name: {Name.PadLeft(20)}\nFirstName: {FirstName.PadLeft(20)}\n" + $"EmailAddress: {Email.PadLeft(30)}\nUserName: {Username.PadLeft(15)}\n\n";

        }
    }
}
