using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N23_HT2
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }

        public User(string firstname, string lastname, string email) 
        {
            FirstName = firstname;
            LastName = lastname;
            EmailAddress = email;
        }

    }
}
