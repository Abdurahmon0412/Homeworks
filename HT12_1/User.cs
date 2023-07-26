using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT12_1
{
    public class User
    {
        string _name;
        string _firstname;
        string _lastname;
        string _fullname;
        public string FullName { 
            get{ return _fullname;}
            set 
            {
                var names = value.Split(' ');
                if (names.Length >= 3 && !(string.IsNullOrEmpty(value)))
                {
                    _name = names[0];
                    _firstname = names[1];
                    _lastname = names[2];
                    _fullname = value;
            }
                else
                {
                throw new ArgumentException("Ism Familya va sharifni tuliq kiriting");
            }
        }
        }

        public User(string fullname)
        {
            FullName = fullname;
        }
    
        public override int GetHashCode()
        {
            return _name.GetHashCode() + _firstname.GetHashCode() + _lastname.GetHashCode();
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
