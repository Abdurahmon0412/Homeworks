Console.WriteLine("email addresizni kiriting: ");
string email = Console.ReadLine();
bool isupper = false;
foreach (var i in email)
{
    if (i >= 'A' && i <= 'Z' || i >= 'a' && i <= 'z' || i >= '0' && i <= '9' || i == '.' || i == '@')
    {
        if (i >= 'A' && i <= 'Z')
        {
            isupper = true;
        }
    }
    else 
    {
        Console.WriteLine($"passwordning ({i}) qismida xotolik topildi");
        isupper = false;
        break;
    }
}
    if(isupper)
    {
        Console.WriteLine($"Emailingizni shu kurinishda bulgani yaxshiroq: {email.ToLower()}");
    }
Console.WriteLine(email);
