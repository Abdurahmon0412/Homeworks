using N22_2_Hometask.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N22_2_Hometask.Model
{
    public class Rewiev : IRewiev
    {
        public Guid Id { get; set; }
        public int Star { get; set; }
        public string Massage { get; set; }

        // New constructor
        public Rewiev(int star, string massage) => (Id, Star, Massage) = (Guid.NewGuid(), star, massage);
        public override string ToString()
        {
            return $"Star: {Star} - Massage {Massage}";
        }
    }
}
