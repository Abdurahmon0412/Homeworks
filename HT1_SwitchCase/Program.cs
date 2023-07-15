using System.Diagnostics;
Random rd = new Random();
string[] tests = 
{
    "Which type works with integer",
    "Whether all types derive from the object type",
    "What are the boolean operators?",
    "Can you convert int to string?",
    "which is value type"
};

string[] trueAnswer =
{
    "int","Yes","True and False","No","12,'c'"
};

string[] falseAnswer =
{
    "Double", "No","Hello and \"1\"","Yes","object, class"
};
int Score = 0;
int trueansver = 0;
List<string> Warning = new List<string>();

for(int i = 0; i < tests.Length; i++)
{
    if(rd.Next(2) == 1)
    {
        Console.WriteLine((i+1) + "\nInput: ");
        Console.WriteLine(tests[i] + "?");
        Console.WriteLine("A)" + trueAnswer[i]);
        Console.WriteLine("B)" + falseAnswer[i]);
        string an = Console.ReadLine();
        if(an == "A")
        {
            Score++;
            trueansver++;
        }
        else if(an == "B")
        {
            Warning.Add(Convert.ToString(tests[i]));
            Warning.Add(Convert.ToString(trueAnswer[i]));
            Score--;
        }
        
    }
    else
    {
        Console.WriteLine((i+1) + "\nInput: ");
        Console.WriteLine(tests[i] + " ?");
        Console.WriteLine("A)" + falseAnswer[i]);
        Console.WriteLine("B)" + trueAnswer[i]);
        string an = Console.ReadLine();
        if (an == "B")
        {
            Score++;
            trueansver++;
        }
        else if (an == "A")
        {
            Warning.Add(Convert.ToString(tests[i]));
            Warning.Add(Convert.ToString(trueAnswer[i]));
        }
    }

    
    
}
Console.WriteLine($"Ball: {Score}");
Console.WriteLine("Invalid Ansvers\n\n");
if (Warning.Count > 0)
{


    for (int i = 0; i < Warning.Count; i++)
    {
        Console.WriteLine("Question: " + Convert.ToString(Warning[i]) + "?");
        i++;
        Console.WriteLine("Answer: " + Warning[i]);
        Console.WriteLine();
    }
}
else
{
    Console.WriteLine("Invalid Answers not found");
}
