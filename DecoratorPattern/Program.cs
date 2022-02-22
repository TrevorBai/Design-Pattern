using System;

namespace DecoratorPattern
{
    class StarbuzzCoffe
    {
        static void Main(string[] args)
        {
            AbstractBeverage beverage = new Espresso();
            Console.WriteLine(beverage.Description + " $" + beverage.Cost());

            AbstractBeverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.Description + " $" + beverage2.Cost());

            AbstractBeverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine(beverage3.Description + " $" + beverage3.Cost());

            Console.ReadKey();
        }
    }
}
