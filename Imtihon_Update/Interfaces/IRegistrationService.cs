using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imtihon_Update.Interfaces
{
    public interface IRegistrationservice
    {

        public bool ChekName(string ism, string familya, string sharif)  { return true; }


        public bool CheckEmailAddress(string email) { return true; }

        public string GenerateUserName(string ism, string sharf) { return ""; }

        public bool Add(string name, string familya, string sharif, string email, ref string username) { return true; }   // - parameterlari - ism, sharif, email address va ixtiyoriy username

        public void Register(string ism, string familya, string sharif, string email, string username) { } //    - parameterlari - ism, sharif, email address va ixtiyoriy username     

        public void Display() { }
    }
}
