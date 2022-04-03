using System;

namespace CommandPattern
{
    public class CeilingFan
    {
        public const int HIGH = 3;
        public const int MEDIUM = 2;
        public const int LOW = 1;
        public const int OFF = 0;

        private readonly string _location;
        private int _speed;

        public CeilingFan(string location)
        {
            _location = location;
            _speed = OFF;
        }

        public void High()
        {
            _speed = HIGH;
            Console.WriteLine(_location + " ceiling fan is on high");
        }

        public void Medium()
        {
            _speed = MEDIUM;
            Console.WriteLine(_location + " ceiling fan is on medium");
        }

        public void Low()
        {
            _speed = LOW;
            Console.WriteLine(_location + " ceiling fan is on low");
        }

        public void Off()
        {
            _speed = OFF;
            Console.WriteLine(_location + " ceiling fan is off");
        }

        public int GetSpeed()
        {
            return _speed;
        }

    }
}
