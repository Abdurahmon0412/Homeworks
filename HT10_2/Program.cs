using HT10_2;

namespace Homeworks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var rd = new Random();

            List<Product> Products = new List<Product>();

            Products.Add(new Product(Guid.NewGuid(), "Shokolad"));
            Products.Add(new Product(Guid.NewGuid(), "Musqaymoq"));
            Products.Add(new Product(Guid.NewGuid(), "Pepsi"));

            var Shopping = new ShoppingCart();

            foreach (var product in Products)
            {
                Shopping.Add(product);
            }

            var exit = true;
            var i = 0;
            while (exit)
            {
                Console.WriteLine("Chiqish uchun exit ni tering! yoki Sotib oladigan mahsulotingizni tanlang 1.....");
                Shopping.AllProducts();
                var tanlov = Console.ReadLine();
                if (tanlov.Contains("exit",StringComparison.OrdinalIgnoreCase))
                break;

                switch (tanlov)
                {
                    case "1":
                        Console.WriteLine(Shopping.Remove(Products[0]));
                        break;
                    case "2":
                        Console.WriteLine(Shopping.Remove(Products[1]));
                        ;
                        break;
                    case "3":
                        Console.WriteLine(Shopping.Remove(Products[2]));

                        break;
                    default:
                        Console.WriteLine("Bunday mahsulot mavjud emas Siz bisning xizmatimizdan tugri foydalaning aks holda foydalanishdan mahrum qilinasiz");
                        exit = i > 2 ? false : true;
                        i++;
                        Thread.Sleep(3000);
                        break;
                }
            }
        }
    }
}    
    
    
    
