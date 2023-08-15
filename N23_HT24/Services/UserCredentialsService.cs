using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using N23_HT24.Models;

namespace N23_HT24.Services
{
    public class UserCredentialsService:IUserCredentialsService
    {
        //IUserCredentialsService dan foydalaning
        //unda quyidagi methodlar bo'lsin 
        //- Add ( userId, password ) -password ni strong ekanligini regex bilan tekshirsin ( 8 <= simvol, 1 <= katta harf, 1 <= son ), valid bo'lsa qo'shsin va credential ni qaytarsin bo'lmasa exception
        //- GetByUserId ( userId ) -user Id bo'yicha credential ni topib qaytarsin, bo'lmasa null
        private  List<UserCredentials> _userCredentials = new List<UserCredentials>();
        
        public UserCredentials Add(Guid userId, string password)
        {
            if (Regex.IsMatch(password, @"^(?=.*[A-Z])(?=.*[0-9])(?=.*[^a-zA-Z0-9]).{8,}$"))
            {
                var userCradential = new UserCredentials(password, userId);
                _userCredentials.Add(userCradential);
                return userCradential;

            }
            else
            {
                throw new InvalidOperationException("User credentials Invalid");
            }
            
        }

        public UserCredentials? GetByUserId(Guid userId)
        {
            return _userCredentials.Any(user => user.Id == userId)
                ? _userCredentials.Find(user => user.Id == userId)
                : null;
        }
    }
}
