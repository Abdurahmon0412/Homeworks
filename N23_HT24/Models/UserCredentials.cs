using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N23_HT24.Models
{
    public class UserCredentials
    {
        //UserCredentials modelidan foydalaning ( id, password, userId )
        public Guid Id { get; set; }
        public string password { get; set; }
        public Guid UserId { get; set; }

        public UserCredentials(string password, Guid userId)
        {
            Id = Guid.NewGuid();
            this.password = password;
            UserId = userId;
        }
    }
}
