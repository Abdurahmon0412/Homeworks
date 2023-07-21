using System.Collections;
using System.Numerics;
namespace Homeworks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string CompanyName = "The Travel Guru";
            string NameToken = "{{Name}}";
            string CompanyNameToken = "{{CompanyName}}";
            string TicketdateToken = "{{TicketDate}}";

            List<string> Names = new List<string>();
            Names.Add("Sardor");
            Names.Add("Qodir");
            Names.Add("G'ayrat");
            Names.Add("Eshmat");

            var empty = new Dictionary<DateTime, int>();
            empty.Add(new DateTime(2020, 12, 4, 20, 30, 0), 7);
            empty.Add(new DateTime(2022, 01, 4, 07, 0, 0), 3);
            empty.Add(new DateTime(2020, 12, 4, 17, 30, 0), 4);

            var EMAIL = new LinkedList<string>();
            EMAIL.AddFirst("Hello {{Name}}. Welcome to onboard. {{CompanyName}} Team.");
            EMAIL.AddLast("Your data is being processed and we will inform updates for you as soon as possible. {{CompanyName}} Team");
            EMAIL.AddLast("Congratulations! Your flight ticket is booked for {{TicketDate}}. {{CompanyName}} Team.");

            Dictionary<string, string> Messages = new Dictionary<string, string>();
            Messages.Add("Underage", "Uzr, hurmatli {{Name}} siz loyidan foydalanish uchun kichkinasiz");
            Messages.Add("GoldenAger", "Uzr, hurmatli {{Name}} loyiha yoshlar uchun mo'ljallangan");
            string nameIS;
            bool IsName = true;
            do
            {
                int count = 0;
                Console.WriteLine("Ismingizni kiriting: ");
                nameIS = Console.ReadLine();
                foreach (var name in nameIS)
                {
                    if (name >= 'A' && name <= 'Z' || name >= 'a' && name <= 'z')
                    {
                        count++;
                    }
                }

                if (string.IsNullOrWhiteSpace(nameIS) || string.IsNullOrEmpty(nameIS))
                {
                    Console.WriteLine("Invalid Name");
                }
                else if (count == nameIS.Length) { IsName = false; }
                else Console.WriteLine("Invalid Name");
            } while (IsName);


            string Age;
            bool IsAge = true;
            Console.WriteLine("Enter age: ");
            do
            {
                int count = 0;
                Age = Console.ReadLine();
                if(string.IsNullOrWhiteSpace(Age) || string.IsNullOrEmpty(Age))
                {
                    Console.WriteLine("Enter age: ");
                }
                foreach (var age in Age)
                {

                    if (age >= '0' && age <= '9')
                    {
                        count++;
                    }
                }
                if(count == Age.Length) { IsAge = false; }
                

            } while (IsAge);
            int yosh = Convert.ToInt32(Age);
            if(yosh < 18)
            {
                Console.WriteLine(Messages["Underage"].Replace(NameToken,nameIS));
                return;
            }
            else if(yosh > 18)
            {
                Names.Add(nameIS);
            }
            else if(yosh > 90)
            {
                Console.WriteLine(Messages["GoldenAger"].Replace(NameToken, nameIS));
                return;
            }
            var IsEpm = new DateTime();
            if(Names.Count == 5)
            {
                foreach (var emp in empty)
                {
                    if(emp.Value > 4)
                    {
                        IsEpm = emp.Key;
                        break;
                    }
                }
            }


            foreach(var name in Names)
            {
                foreach(var email in EMAIL)
                {
                    Console.WriteLine(email.Replace(NameToken,name).Replace(CompanyNameToken,CompanyName).Replace(TicketdateToken,Convert.ToString(IsEpm)));
                }
                Console.WriteLine();
            }



        }




    }
}