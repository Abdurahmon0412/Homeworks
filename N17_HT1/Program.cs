using N17_HT1;
var Menegment = new CarRentalManagement();
CarRental bmw1 = new BMW("X1");
CarRental bmw2 = new BMW("X2");
CarRental bmw3 = new BMW("X3");
CarRental audi1 = new BMW("Y1");
CarRental audi2 = new BMW("Y1");
CarRental audi3 = new BMW("Y3");
Menegment.Add(bmw1);
Menegment.Add(bmw2);
Menegment.Add(bmw3);
Menegment.Add(audi1);
Menegment.Add(audi2);
Menegment.Add(audi3);


Console.WriteLine( Menegment.Rent("BMW"));
await Task.Delay(1000 * 3);
Console.WriteLine(Menegment.Return(bmw1));
Menegment.CalculateBalance();