using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace N19_1
{
    public static class Validator
    {
        public static bool IsValidName(in string name, out string formattedName)
        {
            formattedName = string.Empty;
            if(string.IsNullOrWhiteSpace(name)) return false;

            formattedName = name.Trim();
            if (Regex.IsMatch(formattedName, "^[A-Za-z][A-Za-z0-9]*$"))
                return true;
            return false;
        }


        public static bool IsValidEmailadress(in string emailAddress, out string formattedEmailAddress)
        {
            formattedEmailAddress = string.Empty;
            if (string.IsNullOrWhiteSpace(emailAddress)) return false;

            formattedEmailAddress = emailAddress.Trim();
            return Regex.IsMatch(formattedEmailAddress, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
        }


        public static bool IsValidAge(in string age)
        {
            try
            {

                if (Convert.ToInt32(age) < 1)
                {
                    return false;

                }
                else
                {
                    return true;

                }
            }
            catch
            {
                return false;
            }
        }

        public static bool IsValidPhoneNumber(in string phoheNumber, out string formattedPhoneNumber)
        {
            formattedPhoneNumber = string.Empty;
            if (string.IsNullOrWhiteSpace(phoheNumber)) return false;

            formattedPhoneNumber = phoheNumber.Trim();
            if (Regex.IsMatch(formattedPhoneNumber, @"^\+998\d{9}$"));
            return false;
        }
    }
}
