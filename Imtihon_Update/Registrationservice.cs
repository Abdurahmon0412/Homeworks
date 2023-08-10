using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Imtihon_Update.Interfaces;
namespace Imtihon_Update
{
    public class RegistrationService: IRegistrationservice
    {
        //    - agar ism, sharif, email address valid bo’lmasa ekranga qaysi biri invalid ekanligi chiqarilsin
        List<string> list;
        //Users kolleksiyasi - foydalanuvchilar ma’lumotlarini saqlab turuvchi User tipidagi kolleksiya bo’lsin
        private List<User> Users;

        //Konstructor
        public RegistrationService()
        {
            Users = new List<User>();

            list = new List<string>();
        }


        //- Users kolleksiyasi - foydalanuvchilar ma’lumotlarini saqlab turuvchi User tipidagi kollesiya bo’lsin va unga shu tip ichidangina murojaat qilish mumkin bo’lsin

        //- CheckName - ism / familya / sha’rif ni tekshiradi, valid bo’lsa true, invalid bo’lsa false qaytaradi
        public bool ChekName(string ism, string familya, string sharif)
        {
            var check = true;
            const string regexName = "^[a-zA-Z'-]+$";
            Regex regex = new Regex(regexName);
            if (!regex.IsMatch(ism))
            {
                list.Add("Ism xato kiritildi");
                check = false;
            }
            if (!regex.IsMatch(familya))
            {
                list.Add("Familya xato kiritildi");
                check = false;
            }
            if (!regex.IsMatch(sharif))
            {
                check = false;
                list.Add("Sharifingiz notugri kiritildi");
            }
            return check;
        }

        //- CheckEmailAddress - email manzilini tekshiradi, valid bo’lsa true, invalid bo’lsa false qaytaradi
        public bool CheckEmailAddress(string email)
        {
            var check = true;
            const string regexEmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(regexEmail);
            if (!regex.IsMatch(email) || string.IsNullOrWhiteSpace(email))
            {
                check = false;
                list.Add("Email notugri kiritildi");
            }
            return check;
        }

        //- GenerateUserName methodi - unique username generate qiladi
        public string GenerateUserName(string ism, string sharf)
        {
            var rd = new Random();
            return $"{ism.ToLower()}_{sharf.ToLower()}{rd.Next(10, 100)}";
        }



        private bool Add(string name, string familya, string sharif, string email, ref string username)    // - parameterlari - ism, sharif, email address va ixtiyoriy username
        {
            //    - methodda ism, sharif, email address valid ekanligini tekshirilsin
            //    - username invalid yoki unique bo’lmasa GenerateUsername orqali yangi generate qilinsin
            //    - foydalanuvchi hamma ma’lumotlarni valid bolsa foydalanuvchilar kolleksiyasiga qo’shsin va true qaytarsin aks holda false
            //    - method faqat tip ichidangina murojaat qilish mumkin bo’lsin
            bool checkname = true;
            bool checkemail = true;
            if (!ChekName(name, familya, sharif))
            {
                checkname = false;
            }
            if (!CheckEmailAddress(email))
            {
                checkemail = false;
            }

            foreach (var item in Users)
            {
                if (item.Username.Equals(username, StringComparison.OrdinalIgnoreCase))
                {
                    username = GenerateUserName(name, familya);
                }


            }
            var returntype = checkemail == true && checkname == true ? true : false;
            return returntype;
        }


        public void Register(string ism, string familya, string sharif, string email, string username)   //    - parameterlari - ism, sharif, email address va ixtiyoriy username     
        {
            //    - Register methodi
            //    - parameterlari - ism, sharif, email address va ixtiyoriy username
            //    - Add methodi orqali foydalanuvchini qo’shsin
            //    - agar Add methodi true qaytarsa foydalanuvchiga SendEmail orqali email jo’natsin
            //    - agar SendEmail true qaytarsa foydalanuvchidagi aktiv ekanligini bildiruvchi property ga true qiymat yozilsin
            var userchecker = Add(ism, familya, sharif, email, ref username);
            if (userchecker)
            {
                var user = new User(ism, familya, sharif, email, username);
                if (DispatchEmail.SendEmail(email, username) == true)
                {
                    user.IsActived = true;
                }
                else
                {
                    Console.WriteLine("Internat muommosi tufayli message junatilmadi keyinroq urinib kuring yoki chet elga chiqib junating ");
                }
                Users.Add(user);
            }
            else
            {
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
                list.Clear();
            }
        }

        public void Display()
        {

            if (Users.Count > 0)
            {
                foreach (var user in Users)
                {
                    Console.WriteLine(user);
                }
            }
            else
            {
                Console.WriteLine("Bizda foydalanuvchilar mavjud emas sizga uz hizmatimizni taklif etamiz foydalanish uchun ruyhattan uting");
            }
        }
    }
}
