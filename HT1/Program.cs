﻿var rd = new Random();
Console.WriteLine("Passwordda sonlar qatnashsinmi: ha 1 yuq 0 ");
int son = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Passwordda harflar qatnashsinmi: ha 1 yuq 0 ");
int harf = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Passwordda simvollar qatnashsinmi: ha 1 yuq 0 ");
int simvol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Password uzunligini kiriting ");
int len = Convert.ToInt32(Console.ReadLine());
var password = "";
int i = 0;
while ( i < len / 2)
{


    if (son == 1 )
    {
        password = password + Convert.ToString(Convert.ToChar(rd.Next(48,57)));
        i++;
    }
    else
    {
        break;
    }
}
var j = password.Length;
while ( j < len)
{
    if(harf == 1)
    {
        password = password + Convert.ToString(Convert.ToChar(rd.Next(97,121)));
        j++;
    }
    if (simvol == 1)
    {
        j ++;
        password = password + Convert.ToString(Convert.ToChar(rd.Next(33, 47)));

    }
    
}
Console.WriteLine(password);