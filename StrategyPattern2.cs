using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    class StrategyPattern2
    {
        static void Main(string[] args)
        {
            var consoleWriter = new ConsoleWriter();
            var fileWriter = new FileWriter("output.txt");
            var sim = new Simulation2(10, 1, fileWriter);
            //ICollection<string> results = sim.Run();
            sim.Run();
            //foreach (var result in results)
            //{
            //    Console.WriteLine(result);
            //}

            Console.ReadKey();
        }

        // ############################################################################################

        // Strategy Pattern Example 2
        // Monte Carlo Simulation
        class Simulation1
        {
            Random rnd = new Random();

            public ICollection<string> Run()
            {
                // Flip a coin and return heads 50% and tails 50%
                var results = new List<string>();
                for (int i = 0; i < 10; i++)
                {
                    // Business logic, it has nothing to do with printing logic
                    var random = rnd.NextDouble() <= 0.5 ? "Heads" : "Tails";
                    results.Add(random);
                }
                return results;
            }
        }

        // Better structure
        class Simulation2
        {
            // Polymorphism or strategy pattern
            private IWriter _writer;
            private Random _rnd;
            private int _runNumbers;

            public Simulation2(int runNumbers, int seed, IWriter writer)
            {
                _writer = writer;
                _runNumbers = runNumbers;
                _rnd = new Random(seed);
            }

            public void Run()
            {
                for (int i = 0; i < _runNumbers; i++)
                {
                    // It seems like that _writer.Write() doesn't mean it's printing logic
                    // So it does not break the merge of business logic with printing logic
                    // It seems like to be a wrapper method (don't care about what functionality it's wrapping)
                    var result = _rnd.NextDouble() <= 0.5 ? "Heads" : "Tails";
                    _writer.Write(result);
                }

            }

        }

        interface IWriter
        {
            void Write(string result);
        }

        class ConsoleWriter : IWriter
        {
            public void Write(string result)
            {
                Console.WriteLine(result);
            }
        }

        class FileWriter : IWriter
        {
            private string _path;

            public FileWriter(string path)
            {
                _path = path;
            }

            public void Write(string result)
            {
                // Write the contents of result to the file at path

                // Fake file write
                Console.WriteLine("Writing " + result + " to " + _path);
            }
        }

        class CSVWriter : IWriter
        {
            public void Write(string result)
            {
                // Write to scv file
            }
        }
    }
}
