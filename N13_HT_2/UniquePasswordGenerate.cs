using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N13_HT_2
{
    public class UniquePasswordGenerate : SecurePasswordGenerator
    {
        public List<string> ListPassword = new List<string>();
        public UniquePasswordGenerate(int length, bool hasletter, bool hasdigit = false)
               : base(length, hasletter, hasdigit)
        {

        }

        public string GenerateUniquePassword()
        {
            while (true)
            {
                var password = Generate();
                if (!ListPassword.Contains(password))
                {
                    ListPassword.Add(password);
                    return password;
                }
            }



        }
    }
}
