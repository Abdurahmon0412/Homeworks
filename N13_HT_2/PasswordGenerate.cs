using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N13_HT_2
{
    public class PasswordGenerate
    {
        public int _Length;
        public bool _HasLetters;
        public bool _HasDigit;
        

        public PasswordGenerate(int length, bool hasletter,bool hasdigit = false)
        {
            _Length = length;
            _HasLetters = hasletter;
            _HasDigit = hasdigit;
        }

        public string Generate()
        {
            var rd = new Random();
            string password = "";
            string letters = "qwertyuiopasdfghjklzxcvbnm";
            string numbers = "1234567890";
            for (var passlength  = 0; passlength < _Length; passlength++)
            {
                if (_HasDigit && passlength < _Length)
                {
                    password += numbers[rd.Next(0, numbers.Length)];
                }
                if (_HasLetters && passlength < _Length)
                {
                    password += letters[rd.Next(0, letters.Length)];
                }
            }
            if(password.Length > 0)
            {
                return password;
            }
            else { throw new Exception("password no created");}
        }
    }
}