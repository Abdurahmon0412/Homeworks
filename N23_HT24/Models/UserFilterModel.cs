using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N23_HT24.Models
{
    public class UserFilterModel:FilterModel
    {
        //UserFilterModel dan foydalaning ( firstname?, lastname? ) u FilterModel dan inheritance olgan bo'lsin
        public string? FirstName { get; set; }
        public string? LastName { get; set;}
    }
}
