using N22_2_Hometask.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N22_2_Hometask.Model
{
    public class CrashReport:IRewiev
    {
        public Guid Id { get; set; }
        public int Star { get; set; }
        public string Massage { get; set; }
        public string Screenshot { get; set; }
        public CrashReport(int star, string massage,string screenshot) => (Id, Star, Massage, Screenshot) = (Guid.NewGuid(), star, massage,screenshot);

        public override string ToString()
        {
            return $"Star: {Star} - Massage {Massage}";
        }
    }
}
