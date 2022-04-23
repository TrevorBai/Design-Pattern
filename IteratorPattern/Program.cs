using System;
using System.Collections.Generic;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var pancakeHouseMenu = new PancakeHouseMenu();
            var dinerMenu = new DinerMenu();
            var cafeMenu = new CafeMenu();

            var waitress = new Waitress(new List<IMenu> { pancakeHouseMenu, dinerMenu, cafeMenu });
            waitress.PrintMenu();

            Console.ReadKey();
        }
    }
}
