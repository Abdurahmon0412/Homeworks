using Imtihon_Update;
using Imtihon_Update.Interfaces;
RegistrationService? Registrationservice = new RegistrationService();
bool exit = true;
while (exit)
{
    Console.WriteLine("Dastruni tuxtatish uchun [e] ni bosing");
    Console.WriteLine("Ruyhatdan utish uchun [r] va bizning a'zolarimizni kurish uchun[d] ni bosing");
    var check = Console.ReadLine().ToLower();
    switch (check)
    {
        case "e":
            Console.Clear();
            exit = false;
            break;
        case "r":
            Console.Clear();
            Console.WriteLine("Enter Name ");
            string ism = Console.ReadLine();
            Console.WriteLine("Enter FirstName: ");
            string familya = Console.ReadLine();
            Console.WriteLine("Enter Middle Name: ");
            string sharif = Console.ReadLine();
            Console.WriteLine("Enter email Address: ");
            string email = Console.ReadLine();
            Console.WriteLine("Enter a username");
            string username = Console.ReadLine();
            Registrationservice.Register(ism, familya, sharif, email, username);
            //Registrationservice.Register(ism, familya, sharif, email, username);
            break;
        case "d":
            Console.Clear();
            Registrationservice.Display();
            break;
        default:
            Console.WriteLine("Bunday komanda yuq dasturdan xato foydalandingiz");
            break;
    }
}












