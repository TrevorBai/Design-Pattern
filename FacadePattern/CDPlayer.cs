using System;

namespace FacadePattern
{
    public class CDPlayer
    {
        public string Description { get; set; }
        private int _currentTrack;
        private readonly Amplifier _amplifier;
        private string _title;

        public CDPlayer(Amplifier amplifier)
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
            _title = null;
            Console.WriteLine(Description + " eject");
        }

        public void Play(string title)
        {
            _title = title;
            _currentTrack = 0;
            Console.WriteLine(Description + " playing \"" + title + "\"");
        }

        public void Play(int track)
        {
            if (_title == null)
            {
                Console.WriteLine(Description + " can't play track " + _currentTrack + ", no cd inserted");
                return;
            }

            _currentTrack = track;
            Console.WriteLine(Description + " playing track " + _currentTrack);
        }

        public void Stop()
        {
            _currentTrack = 0;
            Console.WriteLine(Description + " stopped");
        }

        public void Pause()
        {
            Console.WriteLine(Description + " paused \"" + _currentTrack + "\"");
        }

    }
}
