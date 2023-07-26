using HT12_2;

namespace Homeworks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This is vaild Email:\n");

            try
            {
                var ValidEmail = new Email();

                ValidEmail.To = "gani@t.me";
                ValidEmail.From = "abdurahmonsadriddinov0412@gmail.com";
                ValidEmail.Subject = "Xolahvol surash";
                ValidEmail.Content = "Ishlariz yaxshimi";
                Console.WriteLine( ValidEmail.ToString());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.WriteLine("This is Invaild Email: \n");
            try
            {
                var ValidEmail = new Email();

                ValidEmail.To = "gani@.me";
                ValidEmail.From = "abdurahmonsadriddinov0412@gmail.com";
                ValidEmail.Subject = "Xolahvol surash";
                ValidEmail.Content = "hi!";
                Console.WriteLine(ValidEmail.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}








