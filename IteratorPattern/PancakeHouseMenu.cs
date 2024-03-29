﻿using System.Collections.Generic;

namespace IteratorPattern
{
    public class PancakeHouseMenu : IMenu
    {
        private readonly List<MenuItem> _menuItems;

        public PancakeHouseMenu()
        {
            _menuItems = new List<MenuItem>();

            AddItem("K&B's Pancake Breakfast", "Pancakes with scrambled eggs and toast", true, 2.99);
            AddItem("Regular Pancake Breakfast", "Pancakes with fried eggs, sausage", false, 2.99);
            AddItem("Blueberry Pancakes", "Pancakes made with fresh blueberries", true, 3.49);
            AddItem("Waffles", "Waffles with your choice of blueberries or strawberries", true, 3.59);
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            var menuItem = new MenuItem { Name = name, Description = description, Vegetarian = vegetarian, Price = price };
            _menuItems.Add(menuItem);
        }

        public IEnumerator<MenuItem> CreateEnumerator()
        {
            return _menuItems.GetEnumerator();
        }
    }
}
