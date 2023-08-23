using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N29_HT2
{
    public class Employee
    {
        //Employee modeldan foydalaning ( id, firstname, lastname )
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public Employee(string firsname , string lastname, string email)
        {
            Id = Guid.NewGuid();
            FirstName = firsname;
            LastName = lastname;
            EmailAddress = email;
        }
    }
}
