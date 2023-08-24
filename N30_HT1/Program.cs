
using N30_HT1;

string InsideFile = "Loremsd;akldj;askldfdskadlkasdjf[asdkfsjafljkq[ae ipsum dolor sit amet consectetur adipisicing elit. quaerat est quas commodi quibusdam labore, nihil " +
    "doloribus quam temporibus inventore optio expedita consectetur voluptatem QUIDEM nulla soluta earum. Numquam rem alias minima" +
    " culpa iste distinctio. Eum similique est consequuntur minus, odio nisi recusandae iure asperiores facere, reiciendis voluptate " +
    "maiores! Repellat, dolorum!";

var wait = Task.Run(() =>
{
    for (int i = 1; i < 11; i++)
    {
        File.WriteAllText($"{i}.txt", InsideFile);
    }
});

Task.WaitAll(wait);
var documentAnalyser = new DocumentAnalyzer();
for(int i = 1 ; i < 11 ; i++)
{
    Console.WriteLine(documentAnalyser.Analyze($"{i}.txt"));
}