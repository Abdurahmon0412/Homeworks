namespace Homeworks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Task1();
            //Task2();
            Task3();

        }

        public static void Task1()
        {
             //HT 1

            string ism, familiya;
            int yosh;
            Console.WriteLine("Enter your Surname: ");
            ism = Console.ReadLine();
            Console.WriteLine("Enter your Lastname: ");
            familiya = Console.ReadLine();
            Console.WriteLine("Enter your Age: ");
            yosh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ism: {ism} \nFamilya: {familiya}\nYosh:{yosh}");
        }
        public static void Task2()
        {
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

        }

        public static void Task3 ()
        {
            // HT 3

            // Primitive type
            int amount = 100;
            char simbol = 'A';
            Console.WriteLine(amount + "\n" + simbol);
            // complex type 
            var tuday = DateTime.Today;
            Console.WriteLine(tuday.ToShortDateString());

            short valueType1 = 12;
            bool valueType2 = false;
            Console.WriteLine(valueType1 + "\n" + valueType2);

            DateTime referenceType1 = DateTime.Today;
            Console.WriteLine(referenceType1.Year.ToString());

        }
    }

}
