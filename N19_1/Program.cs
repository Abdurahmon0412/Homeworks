using N19_1;

//for name
if (Validator.IsValidName("  Abdurahmon    ", out var formattedName))
    Console.WriteLine($"fixed name - {formattedName}");
else
    Console.WriteLine("Invalid name is not fixed");


// for email
if (Validator.IsValidEmailadress("           test@gamail.com", out var formattedEmailAddress))
    Console.WriteLine($"true fixedEmailAddress - {formattedEmailAddress}");
else
    Console.WriteLine("Invalid email is not fixed");

//for phone number
if (Validator.IsValidPhoneNumber("      +998938399777   ", out var formattedPhoneNumber))
    Console.WriteLine($"true fixed Phone Number - {formattedPhoneNumber}");
else
    Console.WriteLine("Invalid phone number is not fixed");


//for age
var age = Console.ReadLine();
if (Validator.IsValidAge(age))
    Console.WriteLine($"valid age");
else
    Console.WriteLine("Invalid age is not fixed");


