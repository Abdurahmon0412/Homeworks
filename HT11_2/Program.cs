using HT11_2;

namespace Homeworks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var t1 = new Track
            {
                Name = "Dunyo seni togang emas",
                Author = "Java + C#"
            };
            var t2 = new Track
            {
                Name = "Jiyda gullaganda",
                Author = "Bajalar"
            };
            var t3 = new Track
            {
                Name = "Karvon",
                Author = "Sherali Jurayev"
            };
            string[] Tanlovlar = new string[] { "n", "p", "pause", "play" };
            var Musics = new MusicPlayer();
            Musics.MusicList.Add(t1);
            Musics.MusicList.Add(t2);
            Musics.MusicList.Add(t3);
            Musics.Nowtrack = Musics.MusicList[0];
            while(true)
            {
                Console.WriteLine("Choose a command ( next - n, previous - p, pause - pause, play - play )");
                var check = Console.ReadLine();
                if (Tanlovlar.Contains(check.ToLower()))
                {
                    switch (check)
                    {
                        case "n":
                            Musics.Next();
                            Console.WriteLine($"Playing{Musics.Nowtrack.Author} - {Musics.Nowtrack.Name}");
                            break;
                        case "p":
                            Musics.Previous();
                            Console.WriteLine($"Playing{Musics.Nowtrack.Author} - {Musics.Nowtrack.Name}");
                            break;
                        case "pause":
                            Musics.Pause();
                            break;
                        case "play":
                            Musics.Play();
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("Bunday comanda yuq");
                }

            }


        }
    }
}
