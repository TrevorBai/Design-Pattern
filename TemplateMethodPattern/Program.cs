using System;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var teaHook = new TeaWithHook();
            var coffeeHook = new CoffeeWithHook();

            Console.WriteLine("Making tea...");
            teaHook.PrepareRecipe();

            Console.WriteLine("Making coffee...");
            coffeeHook.PrepareRecipe();

            Console.ReadKey();
        }
    }
}
