string[] Predefinded = new string[] { "Kosmanavt", "Korparation", "Alkash", "Olim", "teacher", "usta", "shogird" };
string[] NamesBase = new string[] { "abdurahmonsadriddinov", "abdurahmonvazizbek", "abdulhayevjasurbek", "shodiyorxurramov", "odilbekabdullayev", "gayrattuychiyev", "muhammadrizoqodirov" };
Console.WriteLine("Ism Familyangizni kiriting: ");
string FullName = Console.ReadLine();
//FullName = FullName.Trim();
String Name = "";
var rd = new Random();
var check = true;
foreach (var i in FullName)
{
    if (i >= 'A' && i <= 'Z' || i >= 'a' && i <= 'z')
    {
        Name += Convert.ToString(i).ToLower();
    }

}
foreach (var i in NamesBase)
{
    if (Name.ToLower().Equals(i))
        {
            Console.WriteLine("Bunday User avvaldan mavjud Sizning Usernamiz shunday tahrirlandi");
            Name += Convert.ToString(Convert.ToChar(rd.Next(48, 55)));
            Name += Predefinded[rd.Next(0, Predefinded.Length)];
            Name += "@gmail.com";
            check = false;
        }
        
}
if (check)
{
    Name += Predefinded[rd.Next(0, Predefinded.Length)];
    Name += "@gmail.com";
}
Console.WriteLine(Name);
