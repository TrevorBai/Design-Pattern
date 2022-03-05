using System;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var nyStore = new NYPizzaStore();
            var chicagoStore = new ChicagoPizzaStore();

            var pizza = nyStore.OrderPizza("veggie");
            Console.WriteLine("Ethan ordered a " + pizza.Name + "\n");

            pizza = chicagoStore.OrderPizza("veggie");
            Console.WriteLine("Joel ordered a " + pizza.Name + "\n");

            Console.ReadKey();
        }
    }
}
