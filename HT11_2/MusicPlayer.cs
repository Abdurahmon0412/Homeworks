using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT11_2
{
    public class MusicPlayer
    {
        public List<Track> MusicList = new List<Track>(); 
        public Track Nowtrack { get; set; }
        public bool PauseTrack = true;
        public void Next ()
        {
            if (MusicList[MusicList.Count - 1] == Nowtrack)
            {
                Console.Write("End of Music ");
                Nowtrack = MusicList[0];
                PauseTrack = true;
            }
            else
            {
                for (int i = 1; i < MusicList.Count ; i++)
                {
                    if (MusicList[i - 1] == Nowtrack)
                    {
                        Nowtrack = MusicList[i];
                        PauseTrack = true;
                    }
                    break;
                }
            }
        }

        public void Previous () 
        {
            if (MusicList[0] == Nowtrack)
            {
                Nowtrack = MusicList[MusicList.Count - 1];
                PauseTrack = true;
                return;
            }
            for (int i = 1; i < MusicList.Count; i++)
            {
                if (MusicList[i - 1] == Nowtrack)
                {
                    Nowtrack = MusicList[i ];
                    PauseTrack = true;
                }
                break;
            }

        }

        public void Pause ()
        {
            if (PauseTrack == true)
            {
                Console.WriteLine($"Paused {Nowtrack}");
                PauseTrack = false;
            }
            else
            {
                Console.WriteLine("Music uje pause");
            }
        }

        public void Play ()
        {
            if (PauseTrack == false)
            {
                Console.WriteLine($"Played {Nowtrack}");
                PauseTrack = true;
            }
            else
            {
                Console.WriteLine("Music already played");
            }
        }

    }
}
