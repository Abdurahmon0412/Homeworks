using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N23_HT24.Models
{
    public class User
    {
        //User modelidan foydalaning ( id, firstname, lastname, emailAddress, isDeleted )
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public bool isDeleted { get; set; }

        public User(string firstName, string lastName, string emailAddress)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            this.isDeleted = false;
        }
    }
}
