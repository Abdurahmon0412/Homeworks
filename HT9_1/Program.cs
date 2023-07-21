using System.Net.Mail;
using System.Text.RegularExpressions;

List<string> Emails = new List<string>();
Emails.Add("john.doe @example.com");
Emails.Add("abdurahmonsadriddinov0412@gmail.com");
Emails.Add("john.doetag@example.com");
Emails.Add("test.com");
Emails.Add("sherali23@.com");


//Console.WriteLine(Regex.IsMatch(emailAddress, emailAddressPattern));
//Console.WriteLine(emailAddressRegex.IsMatch(emailAddress));
//var emailAddressPattern = @"^[a-zA-Z0-9.]+@[a-zA-Z0-9]+\.[a-zA-Z0-9]+$";

var emailAddressRegex = new Regex("^[a-zA-Z0-9.]+@[a-zA-Z0-9]+\\.[a-zA-Z0-9]+$");
foreach (string email in Emails)
{
    if (emailAddressRegex.IsMatch(email))
    {
        Console.WriteLine(email + " => Valid email");
    }
    else
    {
        Console.WriteLine(email + " => invalid email");
    }
}


