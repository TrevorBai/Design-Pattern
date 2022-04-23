using System;
using System.Collections.Generic;

namespace IteratorPattern
{
    public class Waitress
    {
        private readonly List<IMenu> _menus;

        public Waitress(List<IMenu> menus)
        {
            _menus = menus;
        }

        public void PrintMenu()
        {
            var i = 0;
            foreach (var menu in _menus)
            {
                var menuIterator = menu.CreateEnumerator();
                PrintMenu(menuIterator, i);
                i++;
            }
        }

        private void PrintMenu(IEnumerator<MenuItem> enumerator, int i)
        {
            switch (i)
            {
                case 0:
                    Console.WriteLine("MENU\n----\nBREAKFAST");
                    break;
                case 1:
                    Console.WriteLine("\nLUNCH");   
                    break;
                case 2:
                    Console.WriteLine("\nDINNER");
                    break;
                default:
                    break;
            }
            while(enumerator.MoveNext())
            {
                var menuItem = enumerator.Current;
                Console.WriteLine(menuItem.Name + ", " + menuItem.Price + " -- " + menuItem.Description);
            }
        }
    }
}
