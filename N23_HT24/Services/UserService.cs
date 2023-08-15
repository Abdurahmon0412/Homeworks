using N23_HT24.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N23_HT24.Services
{
    public class UserService : IUserService
    {
        //IUserService dan foydalaning
        //unda quyidagi methodlar bo'lsin
        
        //- Get ( pageSize, pageToken ) -userlarni pagination bian qaytarsin
        //- Search ( searchKeyword, pageSize, pageToken ) -userlar ni kalit so'z bo'yicha qidirib pagination bilan qaytarsin
        //- Filter ( userFilterModel ) -userlarni filter qilib pagination bilan qaytarsin
        //- Add ( firstname, lastname, emailAddress ) -email address unique bo'lsa user ni qo'shsin va qaytarsin, bo'lmasa exception
        //- Update ( user ) -userlar ichidan berilgan user borligini topib, update qilsin va qaytarsin, bo'lmasa exception
        //- Delete ( id ) -userlar ichidan berilgan id bo'yicha user borligini topib IsDeleted true qilsin, bo'lmasa exception
        
        private List<User> _users = new List<User>();
        //UserService da IUserService ni implement qiling
        public User Add(string firstname, string lastname, string emailaddress)
        {
            if(!_users.Any(user => user.EmailAddress.Equals(firstname, StringComparison.OrdinalIgnoreCase)))
            {
                var newUser = new User(firstname, lastname, emailaddress);
                _users.Add(newUser);
                return newUser;
            }
            else
            {
                throw new InvalidOperationException("This user already exists");
            }

        }

        public void Delete(Guid id)
        {

            if (_users.Any(user => user.Id == id))
            {
                var newUser = _users.Find(user => user.Id == id);
                newUser.isDeleted = true;
            }
            else
            {
                throw new ArgumentNullException("Argument not found ");
            }
        }

        public List<User> Filter(UserFilterModel userFilterModel)
        {
            //- Filter ( userFilterModel ) -userlarni filter qilib pagination bilan qaytarsin
            return _users.Where(
                user => !user.isDeleted &&
                        (userFilterModel.FirstName == null || user.FirstName.Equals(userFilterModel.FirstName)) &&
                        (userFilterModel.LastName  == null ||user.LastName.Equals(userFilterModel.LastName)))
                .ToList();
        }

        public List<User>Get(int pagesize, int pagetoken)
        {
            return _users.Where(user => !user.isDeleted)
                         .Skip((pagetoken - 1) * pagesize ).Take(pagesize).ToList();
        }

        public List<User> Search(string searchkeyword, int pagesize, int pagetoken)
        {
            return _users.Where(
                    user => !user.isDeleted &&
                        user.EmailAddress.ToLower().Contains(searchkeyword,StringComparison.OrdinalIgnoreCase)||
                                 user.FirstName.ToLower().Contains(searchkeyword , StringComparison.OrdinalIgnoreCase)||
                                 user.LastName.ToLower().Contains(searchkeyword , StringComparison.OrdinalIgnoreCase) )
                .Skip((pagetoken - 1) * pagesize).Take(pagesize).ToList();
        }

        public User Update(User users)
        {
            var updateUser = _users.Find(user => user.Id == users.Id);
            updateUser.FirstName = users.FirstName;
            updateUser.LastName = users.LastName;
            updateUser.EmailAddress = users.EmailAddress;
            updateUser.isDeleted = users.isDeleted;
            return updateUser;
        }
    }
}
