using System;

namespace CommandPattern
{
    public class TV
    {
        private readonly string _location;

        public TV(string location)
        {
            _location = location;
        }

        public void On()
        {
            Console.WriteLine(_location + " TV is on");
        }

        public void Off()
        {
            Console.WriteLine(_location + " TV is off");
        }

        public void SetDVD()
        {
            Console.WriteLine(_location + " TV channel is set for DVD");
        }
    }
}
