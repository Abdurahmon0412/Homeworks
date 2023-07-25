
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT11_1
{
    public class ToDo
    {
        public string TaskName;
        public bool Isdone = false;
        public ToDo(string taskname) 
        {
            TaskName = taskname;
        }

    }
}
