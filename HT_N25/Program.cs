//using HT_N25.Models;
//using HT_N25.Services;

//ProductService productService = new ProductService();
//PaymentService paymentService = new PaymentService();
//var orderService = new OrderService();

//Laptop laptop1 = new Laptop("Intel", "i7", "High Performance Laptop", "Powerful laptop for gaming and work", true, 1299.99);
//Laptop laptop2 = new Laptop("AMD", "Ryzen 5", "Budget Laptop", "Affordable laptop for everyday use", false, 599.99);
//Laptop laptop3 = new Laptop("Apple", "M1", "MacBook Air", "Sleek and lightweight laptop for productivity", true, 999.99);
//Laptop laptop4 = new Laptop("Lenovo", "ThinkPad X1 Carbon", "Business Ultrabook", "Professional laptop with excellent build quality", true, 1499.99);



using Monitor = HT_N25.Models.Monitor;
using HT_N25.Models;
using HT_N25.Services;

var productService = new ProductService();
var paymentService = new PaymentService();

var orderService = new OrderService(productService, paymentService);

//add monitors
var monitor1 = new Monitor("Monitor_15_6", "Oled", false, 8_500_000, 10, 244); ;
productService.Add(monitor1);

var monitor2 = new Monitor("Monitor2", "Oled2", false, 9_750_000, 18, 120); ;
productService.Add(monitor2);

var monitor3 = new Monitor("Monitor3", "Oled3", false, 1_000_000, 15, 144); ;
productService.Add(monitor3);

var monitor4 = new Monitor("Monitor4", "Oled4", false, 1_050_000, 18, 120); ;
productService.Add(monitor4);

// add laptops
var leptop1 = new Laptop("HP", "victuz", "inter", "smd", false, 5_000_000);
productService.Add(leptop1);

var leptop2 = new Laptop("Asus", "ajoyib2", "intel", "celeron",false, 6_000_000);
productService.Add(leptop2);

var leptop3 = new Laptop("touf", "linuz", "CoreI5", "amd", false, 7_000_000);
productService.Add(leptop3);

// add chairs
//public Chair(double maxWeight, string material, string name, string description, bool isOrdered, double price)

var chair1 = new Chair(20.5,"Chair1", "Chair1", "Descroption",false, 200_000);
productService.Add(chair1);

var chair2 = new Chair(13,"materila", "Chair2", "nimadir", false, 200_000);
productService.Add(chair2);
var chair3 = new Chair(15,"materila", "chair3","nimadir", false, 400_000 );
productService.Add(chair3);

Console.WriteLine("Hozirda mavjud tiplar: ");
productService.GetFilterData().ProductTypes.ForEach(Console.WriteLine);

var myCard = new DebitCard { CardNumber = "860000000000", Balance = 10_000_000 };

Console.WriteLine("balance: " + myCard.Balance);

if (orderService.Order(chair1.Id, myCard))
    Console.WriteLine("Sotib olindi");
else
{
    Console.WriteLine("Xatolik");
}

Console.WriteLine("balance: " + myCard.Balance);
