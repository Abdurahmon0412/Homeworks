using N17_HT1;

var management = new CarRentalManagement();
CarRental bmw1 = new Bmw("BMW - 08");
CarRental bmw2 = new Bmw("BMW - 2");
CarRental bmw3 = new Bmw("BMW - T3");

CarRental audi1 = new Audi("Audi-1");
CarRental audi2 = new Audi("Audi- T2");
CarRental audi3 = new Audi("Audi-  3");

management.Add(bmw1);
management.Add(bmw2);
management.Add(bmw3);
management.Add(audi1);
management.Add(audi2);
management.Add(audi3);



var rent1 = management.Rent("BMW");
await Task.Delay(1000 * 5);
management.Return(rent1);

var rent2 = management.Rent("BMW");
await Task.Delay(1000 * 2);
management.Return(rent2);

var rent3 = management.Rent("AUDI");
await Task.Delay(1000 * 4);
management.Return(rent3);

var rent4 = management.Rent("BMW");
await Task.Delay(1000 * 3);
management.Return(rent4);

management.CalculateBalance();
