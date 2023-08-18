using N26_HT2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N26_HT2
{
    public class Skills
    {
        //- Skill modelidan foydalaning(id, name, level )
        public int Id { get; set; }
        public string Name { get; set; }
        public SkillLevels Level { get; set; }

        public Skills(int id,string name, SkillLevels lavel)
        {
            Id = id;
            Name = name;
            Level = lavel;
        }
    }
}
