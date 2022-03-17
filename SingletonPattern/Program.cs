using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var chocoBoiler = ChocolateBoiler.GetInstance();

            Console.WriteLine("Is empty? " + chocoBoiler.IsEmpty());
            chocoBoiler.Fill();
            Console.WriteLine("After filling, is empty? " + chocoBoiler.IsEmpty());

            Console.ReadKey();
        }
    }
}
