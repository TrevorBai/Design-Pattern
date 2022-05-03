using System;
using System.Collections.Generic;

namespace CompositePattern
{
    public class Menu : AbstractMenuComponent
    {
        private readonly List<AbstractMenuComponent> _menuComponents = new List<AbstractMenuComponent>();
        private readonly string _name;
        private readonly string _description;

        public Menu(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public override void Add(AbstractMenuComponent menuComponent)
        {
            _menuComponents.Add(menuComponent);
        }

        public override void Remove(AbstractMenuComponent menuComponent)
        {
            _menuComponents.Remove(menuComponent);
        }

        public override AbstractMenuComponent GetChild(int i)
        {
            return _menuComponents[i];
        }

        public override string GetName()
        {
            return _name;
        }

        public override string GetDescription()
        {
            return _description;
        }

        public override void Print()
        {
            Console.Write("\n" + GetName());
            Console.WriteLine(", " + GetDescription());
            Console.WriteLine("-------------------------------");
            foreach (var menuComponent in _menuComponents)
            {
                menuComponent.Print();
            }
        }

    }
}
