using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N23_HT24.Models
{
    public abstract class FilterModel
    {
        //FilterModel abstrakt modeldan foydalaning ( pageSize, pageToken )
        public int PageSize { get; set; }
        public int PageToken { get; set; }


    }
}
