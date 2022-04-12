using System;

namespace FacadePattern
{
    public class Tuner
    {
        public string Description { get; set; }
        private double _frequency;

        public Tuner()
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

        public void SetFrequency(double frequency)
        {
            _frequency = frequency;
            Console.WriteLine(Description + " setting frequency to " + frequency.ToString());
        }

        public void SetAM()
        {
            Console.WriteLine(Description + " setting AM mode");
        }

        public void SetFM()
        {
            Console.WriteLine(Description + " setting FM mode");
        }
    }
}
