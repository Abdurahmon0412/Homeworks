using N13_HT_2;

var password1 = new PasswordGenerate(10,true,true);
var password3 = new SecurePasswordGenerator(10,true,false);
var password2 = new PasswordGenerate(0, true);
var password4 = new UniquePasswordGenerate(10,true,true);
Console.WriteLine("Password is:" + password3.Generate(true));
Console.WriteLine("Password is: "  + password1.Generate());
Console.WriteLine("Password is: " + password4.GenerateUniquePassword());
Console.WriteLine("Password is: " + password2.Generate());





