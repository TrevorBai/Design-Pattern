using System;

namespace FacadePattern
{
    public class TheaterLights
    {
        public string Description { get; set; }

        public void On()
        {
            Console.WriteLine(Description + " on");
        }

        public void Off()
        {
            Console.WriteLine(Description + " off");
        }

        public void Dim(int level)
        {
            Console.WriteLine(Description + " dimming to " + level + "%");
        }

    }
}
