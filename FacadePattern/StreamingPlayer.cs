using System;

namespace FacadePattern
{
    public class StreamingPlayer
    {
        public string Description { get; set; }
        private string _movie;
        private int _currentTrack;

        public void On()
        {
            Console.WriteLine(Description + " on");
        }

        public void Off()
        {
            Console.WriteLine(Description + " off");
        }

        public void Play(string movie)
        {
            _movie = movie;
            Console.WriteLine(Description + " playing \"" + movie + "\"");
        }

        public void Stop()
        {
            _currentTrack = 0;
            Console.WriteLine(Description + " stopped \"" + _movie + "\"");
        }

    }
}
