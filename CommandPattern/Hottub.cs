using System;

namespace CommandPattern
{
    public class Hottub
    {
        private bool _on;
        private int _temperature;

        public Hottub()
        {
        }

        public void On()
        {
            _on = true;
        }

        public void Off()
        {
            _on = false;
        }

        public void BubblesOn()
        {
            if (_on) Console.WriteLine("Hottub is bubbling!");
        }

        public void BubblesOff()
        {
            if (_on) Console.WriteLine("Hottub is not bubbling!");
        }

        public void JetsOn()
        {
            if (_on) Console.WriteLine("Hottub jets are on");
        }

        public void JetsOff()
        {
            if (_on) Console.WriteLine("Hottub jets are off");
        }

        public void SetTemperature(int temperature)
        {
            _temperature = temperature;
        }

        public void Heat()
        {
            Console.WriteLine("Hottub is heating to a steaming " + _temperature + " degrees");
        }

        public void Cool()
        {
            Console.WriteLine("Hottub is cooling to " + _temperature + " degrees");
        }
    }
}
