using System;

namespace FacadePattern
{
    public class Projector
    {
        private readonly StreamingPlayer _dvdPlayer;

        public string Description { get; set; }

        public Projector(StreamingPlayer dvdPlayer)
        {
            _dvdPlayer = dvdPlayer;
        }

        public void On()
        {
            Console.WriteLine(Description + " on");
        }

        public void Off()
        {
            Console.WriteLine(Description + " off");
        }

        public void WideScreenMode()
        {
            Console.WriteLine(Description + " in widescreen mode (16x9 aspect ratio)");
        }

        public void TVMode()
        {
            Console.WriteLine(Description + " in tv mode (4x3 aspect ratio)");
        }
    }
}
