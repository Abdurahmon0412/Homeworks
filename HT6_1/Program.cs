using System.Reflection.Metadata;

string[] Students = new string[]
{
    "Jasur",
    "Azizbek",
    "Bobur",
    "Firdavs",
    "Odil",
    "Fozil",
    "Qobil",
    "Abdurahmon",
    "Eshmat",
    "Shermat"

};
int[] Score = new int[]
{
    76,
    74,
    89,
    34,
    97,
    87,
    96,
    99,
    12,
    2
};
int maxScore = 0;
int minScore = 0;
int scores = 0;
int Count80 = 0;
int Count90 = 0;
for (int i = 0; i < 10; i++)
{
    scores += Score[i];
    if (Score[i] > maxScore)
        maxScore = Score[i];


}
minScore = maxScore;
for (int i = 0; i < 10; i++)
{
    if (Score[i] < minScore)
        minScore = Score[i];
}
Console.WriteLine($"Max Score = {maxScore}");
Console.WriteLine($"Urtacha ball = {scores / Score.Length}");
Console.WriteLine($"Min Score = {minScore}");


for (int i = 0; i < 10; i++)
{
    if (Score[i] > 80)
        Count80++;
    if (Score[i] > 90)
        Count90++;
}
Console.WriteLine($"80 balldan zoyod olgan studentlar soni: {Count80} ta");
Console.WriteLine($"90 balldan zoyod olgan studentlarsoni: {Count90} ta");
Console.WriteLine("\nSutudents List");

for (int BallA = 0; BallA < Score.Length - 1; BallA++)
{
    for(int BallB = BallA;BallB < Score.Length; BallB++)
    {
        if (Score[BallA] < Score[BallB])
        {
            string temps = Students[BallA];
            Students[BallA] = Students[BallB];
            Students[BallB] = temps;

            int temp = Score[BallA];
            Score[BallA] = Score[BallB];
            Score[BallB] = temp;
        }
    }
}
for (int print = 0;print < Score.Length; print++)
{
    if (Score[print] > 90)
    {


        Console.WriteLine($"{Students[print]} - Top ({Score[print]}) Ball");
    }
    else if (Score[print] > 80)
    {
        Console.WriteLine($"{Students[print]} - Good ({Score[print]}) Ball");
    }
    else if (Score[print] < 70)
        Console.WriteLine($"{Students[print]} - Fail ({Score[print]})Ball");
}
