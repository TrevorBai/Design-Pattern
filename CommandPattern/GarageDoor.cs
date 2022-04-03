using System;

namespace CommandPattern
{
    public class GarageDoor
    {
        private readonly string _location;

        public GarageDoor(string location)
        {
            _location = location;
        }

        public void Up()
        {
            Console.WriteLine(_location + " garage door is up");
        }

        public void Down()
        {
            Console.WriteLine(_location + " garage door is down");
        }

        public void Stop()
        {
            Console.WriteLine(_location + " garage door movement is stopped");
        }

        public void LightOn()
        {
            Console.WriteLine(_location + " garage door light is on");
        }

        public void LightOff()
        {
            Console.WriteLine(_location + " garage door light is off");
        }
    }
}
