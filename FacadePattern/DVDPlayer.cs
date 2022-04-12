using System;

namespace FacadePattern
{
    public class DVDPlayer
    {
        public string Description { get; set; }
        private int _currentTrack;
        private readonly Amplifier _amplifier;
        private string _movie;

        public DVDPlayer(Amplifier amplifier)
        {
            _amplifier = amplifier;
        }

        public void On()
        {
            Console.WriteLine(Description + " on");
        }

        public void Off()
        {
            Console.WriteLine(Description + " off");
        }

        public void Eject()
        {
            _movie = null;
            Console.WriteLine(Description + " eject");
        }

        public void Play(string movie)
        {
            _movie = movie;
            _currentTrack = 0;
            Console.WriteLine(Description + " playing \"" + movie + "\"");
        }

        public void Play(int track)
        {
            if (_movie == null)
            {
                Console.WriteLine(Description + " can't play track " + track.ToString() + " no dvd inserted");
                return;
            }

            _currentTrack = track;
            Console.WriteLine(Description + " playing track " + _currentTrack.ToString() + " of \"" + _movie + "\"");
        }

        public void Stop()
        {
            _currentTrack = 0;
            Console.WriteLine(Description + " stopped \"" + _movie + "\"");
        }

        public void Pause()
        {
            Console.WriteLine(Description + " paused \"" + _movie + "\"");
        }

        public void SetTwoChannelAudio()
        {
            Console.WriteLine(Description + " set two channel audio");
        }

        public void SetSurroundAudio()
        {
            Console.WriteLine(Description + " set surround audio");
        }


    }
}
