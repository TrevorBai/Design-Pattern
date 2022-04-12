using System;

namespace FacadePattern
{
    public class Amplifier
    {
        public string Description { get; set; }
        private Tuner _tuner;
        private StreamingPlayer _player;
        private DVDPlayer _dvd;
        private CDPlayer _cd;

        public Amplifier()
        {
        }

        public void On()
        {
            Console.WriteLine(Description + " on");
        }

        public void Off()
        {
            Console.WriteLine(Description + " off");
        }

        public void SetStereoSound()
        {
            Console.WriteLine(Description + " stereo mode on");
        }

        public void SetSurroundSound()
        {
            Console.WriteLine(Description + " surround sound on (5 speakers, 1 subwoofer)");
        }

        public void SetVolume(int level)
        {
            Console.WriteLine(Description + " setting volume to " + level);
        }

        public void SetTuner(Tuner tuner)
        {
            _tuner = tuner;
            Console.WriteLine(Description + " setting tuner to " + tuner.Description);
        }

        public void SetDVD(DVDPlayer dvd)
        {
            _dvd = dvd;
            Console.WriteLine(Description + " setting DVD player to " + dvd.Description);
        }

        public void SetCD(CDPlayer cd)
        {
            _cd = cd;
            Console.WriteLine(Description + " setting CD player to " + cd.Description);
        }

        public void SetStreamingPlayer(StreamingPlayer player)
        {
            _player = player;
            Console.WriteLine(Description + " setting streaming player to " + player.Description);
        }

    }
}
