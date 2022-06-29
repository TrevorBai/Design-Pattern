using System;

namespace Remoting
{
    // Server class
    public class GumballMachineServer : MarshalByRefObject
    {
        private static string _location;
        private static uint _count;
        private readonly AbstractState _state;

        public GumballMachineServer()
        {
            _state = new NoQuarterState(this);
        }

        public string GetLocation()
        {
            return _location;
        }

        public uint GetCount()
        {
            return _count;
        }

        public AbstractState GetState()
        {
            return _state;
        }

        public void GetDataFromClient(string locationFromClient, uint countFromClient)
        {
            _location = locationFromClient;
            _count = countFromClient;
        }

        public void Report()
        {
            Console.WriteLine("\nGumball Machine: " + _location);
            Console.WriteLine("Current inventory: " + _count + " gumballs");
            Console.WriteLine("Current state: " + _state);
        }
    }
}
