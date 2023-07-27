using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N13_HT_2;
namespace N13_HT_2
{
    public class SecurePasswordGenerator : PasswordGenerate
    {
        public SecurePasswordGenerator(int length, bool hasletter, bool hasdigit = false) 
               :base(length, hasletter, hasdigit)
        {
        }

        public string Generate(bool hassimbol)
        {
            var rd = new Random();
            string password = "";
            string letters = "qwertyuiopasdfghjklzxcvbnm";
            string numbers = "1234567890";
            string simbols = "!@#$%^&*()_+=*~/\\][}{|:'\";.<>,?";
            for (var passlength = 0; passlength < _Length; passlength++)
            {
                if (_HasDigit && passlength < _Length)
                {
                    password += numbers[rd.Next(0, numbers.Length)];
                }
                if (_HasLetters && passlength < _Length)
                {
                    password += letters[rd.Next(0, letters.Length)];
                }
                if(hassimbol && passlength < _Length)
                {
                    password += simbols[rd.Next(0, simbols.Length)];
                }
            }
            if (password.Length > 0)
            {
                return password;
            }
            else { throw new Exception("password no created"); }


        }
    }
}
