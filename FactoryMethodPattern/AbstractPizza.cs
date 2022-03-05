using System;

namespace FactoryMethodPattern
{
    public abstract class AbstractPizza
    {
        public string Name { get; set; }
        public IDough Dough { get; set; }
        public ISauce Sauce { get; set; }
        public IVeggies[] Veggies { get; set; }
        public ICheese Cheese { get; set; }
        public IPepperoni Pepperoni { get; set; }
        public IClams Clam { get; set; }

        public abstract void Prepare();

        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public override string ToString()
        {
            // code to print pizza here
            return null;
        }

    }
}
