bool IsPrime(int prime)
{
    for (int i = 2; i < Math.Sqrt(prime) + 1; i++)
    {
        if (prime % i == 0)
        {
            return false;
        }
    }
    return true;
}

List<int> Numbers = new List<int>
{
    0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18,
    52,45,47,79,53,23,25,49
};

Numbers.Where(number => IsPrime(number) == true).OrderByDescending(a => a).ToList().ForEach(Console.WriteLine);
//Numbers.Where(number => IsPrime(number) == true).ToList().ForEach(Console.WriteLine);


