using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N22_2_Hometask.Interfaces
{
    public interface IRewiev
    {
        public Guid Id { get; set; }
        public int Star { get; set; }
        public string Massage { get; set; }


    }
}
