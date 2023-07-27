using N13_HT1;
namespace Homeworks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var sparrow = new Sparrow();
            var tiger = new Tiger();
            var greatwhiteshark = new GreatWhiteShark();
            Console.WriteLine(sparrow.Fly());
            Console.WriteLine(tiger.Run());
            Console.WriteLine(greatwhiteshark.Swim());
        }
    }
}