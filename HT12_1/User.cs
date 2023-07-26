using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT12_1
{
    public class User
    {
        public string Name { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public string FullName => $"{Name} {Firstname} {Lastname}";
        
    
        public override int GetHashCode()
        {
            return FullName.GetHashCode();
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
