using System;

namespace CompoundPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var simulator = new DuckSimulator();
            var duckFactory = new CountingDuckFactory();

            simulator.Simulate(duckFactory);

            Console.ReadKey();
        }
    }
}
