namespace Homeworks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // HT 1

            //string ism, familiya;
            //int yosh;
            //Console.WriteLine("Enter your Surname: ");
            //ism = Console.ReadLine();
            //Console.WriteLine("Enter your Lastname: ");
            //familiya = Console.ReadLine();
            //Console.WriteLine("Enter your Age: ");
            //yosh = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Ism: {ism} \nFamilya: {familiya}\nYosh:{yosh}");

            // HT 2

            //for bugungi sana
            DateTime today = DateTime.Today.Date;
            Console.WriteLine($"{today.Year}/{today.Month}/{today.Day}");

            // for 1970 yil 1-yanvar
            string sana = "1970 yil 1-yanvar";
            Console.WriteLine(sana);

            // for 75 yosh
            int age = 75;
            Console.WriteLine($"{age} yosh");

            //for 35.5$
            double price = 35.5;
            Console.WriteLine($"{price}$");

            // for Max Developer
            string NicName = "Abdurahmon Developer";
            Console.WriteLine(NicName);

            // HT 3

            // Primitive type
            int amount = 100;
            char simbol = 'A';
            Console.WriteLine(amount + "\n" + simbol);
            // complex type 
            DateTime tomorrow = DateTime.Today.AddDays(1);
            Console.WriteLine(tomorrow);
        }
    }

}
