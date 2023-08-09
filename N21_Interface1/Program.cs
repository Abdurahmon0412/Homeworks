
//dasturda o'zingiz xohlagan payment provider ( KapitalUzcard, MillyHumo ) dan instance ( object ) yarating
//- OnlineMarket dan o'sha provider bilan instance yarating
//- Product dam bir nechta instance yarating va OnlineMarket ga qo'shing
//- o'zingiz xohlagan kartadan ( KapitalUzcard yoki MillyHumo ) instance yarating 
//- bir nechta produktlarni sotib olish operatsiyasini OnlineMarket orqali bajaring
//- kartada qolgan summani ekranga chiqaring


using N21_Interface1;
using N21_Interface1.Cards;
using N21_Interface1.Interfaces;
using N21_Interface1.Providers;

IPaymentProvider Payme = new PaymePaymentProvider();
//IPaymentProvider Uzum = new UzumPaymentProvider();



var OnlaynMarket1 = new OnlineMarket(Payme);
//var OnlaynMarket2 = new OnlineMarket(Uzum);
Product product1 = new Product("Cola", 1000);
Product product2 = new Product("Pepsi", 1200);
Product product3 = new Product("Qurt", 500);
Product product4 = new Product("zizi", 5000);
Product product5 = new Product("Parashok", 14000);

OnlaynMarket1.Add(product1);
OnlaynMarket1.Add(product2);
OnlaynMarket1.Add(product3);
OnlaynMarket1.Add(product4);
OnlaynMarket1.Add(product5);

IDebitCard uzcard = new KapitalUzcard("12234567890123654", "Hamkorbank", 2000000);
IDebitCard humo = new MilliyHumo("11111211111111111", "Agrobank", 5000000);

OnlaynMarket1.Buy("Cola", 3, uzcard);
Console.WriteLine($"Kartadagi mablag': " + uzcard.Balance);
OnlaynMarket1.Buy("zizi", 3, uzcard);
Console.WriteLine($"Kartadagi mablag': " + uzcard.Balance);
OnlaynMarket1.Buy("parashok", 3, uzcard);
Console.WriteLine($"Kartadagi mablag': " + uzcard.Balance);
OnlaynMarket1.Buy("qurt", 3, uzcard);









