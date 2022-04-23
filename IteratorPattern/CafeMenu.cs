using System;
using System.Collections.Generic;

namespace IteratorPattern
{
    public class CafeMenu : IMenu
    {
        private readonly Dictionary<string, MenuItem> _menuItems = new Dictionary<string, MenuItem>();

        public CafeMenu()
        {
            AddItem("Soup of the day", "A cup of soup of the day, with a side salad", false, 3.69);
            AddItem("Burrito", "A large burrito, with whole pinto beans, salsa, guacamole", true, 4.29);
            AddItem("Veggie Burger and Air Fries", "Veggie burger on a whole wheat bun, lettuce, tomato, and fries", true, 3.99);
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            var menuItem = new MenuItem { Name = name, Description = description, Vegetarian = vegetarian, Price = price };
            _menuItems.Add(name, menuItem);
        }

        public IEnumerator<MenuItem> CreateEnumerator()
        {
            return _menuItems.Values.GetEnumerator();
        }
    }
}
