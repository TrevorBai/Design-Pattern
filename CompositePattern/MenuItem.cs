using System;

namespace CompositePattern
{
    public class MenuItem : AbstractMenuComponent
    {
        private readonly string _name;
        private readonly string _description;
        private readonly bool _vegetarian;
        private readonly double _price;

        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            _name = name;
            _description = description;
            _vegetarian = vegetarian;
            _price = price;
        }

        public override string GetName()
        {
            return _name;
        }

        public override string GetDescription()
        {
            return _description;
        }

        public override double GetPrice()
        {
            return _price;
        }

        public override bool IsVegetarian()
        {
            return _vegetarian;
        }

        public override void Print()
        {
            Console.Write("  " + GetName());
            if (IsVegetarian()) Console.Write("(v)");
            Console.Write(", " + GetPrice() + "\n");
            Console.WriteLine("     -- " + GetDescription());
        }

    }
}
