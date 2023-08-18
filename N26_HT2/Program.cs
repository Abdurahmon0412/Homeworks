




//- Skill modelidan foydalaning(id, name, level )

//CollectionExtensions static modelidan ( class ) foydalaning

//unda quyidagi extension methodlar bo'lsin 

//- Update ( this ICollection<Skill> first, ICollection<Skill> second )

//bunda first kolleksiyadan second kolleksiyadagi ichidan quyidagi turkumdagi itemlarni topib, amallar bajarish kerak
//- added - qo'shilganlar ( second da bor, first da yo'q ) -bularni first ga qo'shish kerak
//- removed - o'chirilganlar ( second da yo'q, first da bor ) -bularni first dan o'chirish kerak
//- updated - o'zgartirilgan ( first da va second da bor va o'zgartirilgan ) -bularni first da update qilish kerak ( id dan tashqari ) 

using System.Text.Json;
using N26_HT2;
using N26_HT2.Enums;
using N26_HT2.Extention;


var skillsA = new List<Skills>
{
    new("Vue", SkillLevels.Beginner),
    new("Angular", SkillLevels.Experienced),
    new("React", SkillLevels.Master),
    new(".NET", SkillLevels.Expert),
    new("Python", SkillLevels.Beginner),
};

Console.WriteLine(JsonSerializer.Serialize(skillsA));
Console.WriteLine();

var updatedItemA = skillsA[2];
updatedItemA.Name = "Node.js";
var updatedItemB = skillsA[2];
updatedItemB.Level = SkillLevels.Beginner;

var skillB = new List<Skills>
{
    new("Ruby", SkillLevels.Experienced),
    new("Swift", SkillLevels.Expert),
    updatedItemA,
    updatedItemB,
    skillsA[0],
    skillsA[3],
};

Console.WriteLine(JsonSerializer.Serialize(skillB));
Console.WriteLine();

var result = skillsA.Update(skillB);
Console.WriteLine(JsonSerializer.Serialize(result));
