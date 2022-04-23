using System;
using System.Collections.Generic;

namespace IteratorPattern
{
    public class DinerMenu : IMenu
    {
        private const int MAX_ITEMS = 6;
        private int _numberOfItems = 0;
        private readonly MenuItem[] _menuItems;

        public DinerMenu()
        {
            _menuItems = new MenuItem[MAX_ITEMS];

            AddItem("Vegetarian BLT", "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99);
            AddItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99);
            AddItem("Soup of the day", "Soup of the day, with a side of potato salad", false, 3.29);
            AddItem("Hot Dog", "A hot dog, with sauerkraut, relish, onions, topped with cheese", false, 3.05);
            AddItem("Steamed Veggies and Brown Rice", "Steamed vegetables over brown rice", true, 3.99);
            AddItem("Pasta", "Spaghetti with marinara sauce, and a slice of sourdough bread", false, 3.89);
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            var menuItem = new MenuItem { Name = name, Description = description, Vegetarian = vegetarian, Price = price };

            if (_numberOfItems >= MAX_ITEMS)
            {
                Console.WriteLine("Sorry, menu is full! Can't add item to menu");
                return;
            }

            _menuItems[_numberOfItems] = menuItem;
            _numberOfItems++;
        }

        public IEnumerator<MenuItem> CreateEnumerator()
        {
            return new DinerMenuIterator(_menuItems);
        }
    }
}
