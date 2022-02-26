using System;

namespace FactoryPattern
{
    class PizzaTestDrive
    {
        static void Main(string[] args)
        {
            var nyStore = new NYPizzaStore();
            var chicagoStore = new ChicagoPizzaStore();

            var pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine("Ethan ordered a " + pizza.Name + "\n");

            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine("Joel ordered a " + pizza.Name + "\n");

            Console.ReadKey();
        }
    }
}
