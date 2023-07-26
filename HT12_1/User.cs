using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT12_1
{
    public class User
    {
        string Name { get; set; }
        string Firstname { get; set; }
        string Lastname { get; set; }

        public string FullName => $"{Name} {Firstname} {Lastname}";
        
    
        public override int GetHashCode()
        {
            return Name.GetHashCode() + Firstname.GetHashCode() + Lastname.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if(obj is User user)
            {
                return this.GetHashCode() == user.GetHashCode();
            }
            return false;
        }
    }
}
