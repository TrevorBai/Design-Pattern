using System;

namespace StrategyPattern
{
    class Program
    {
        // MiniDuckSimulator
        static void Main(string[] args)
        {
            AbstractDuck mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();

            AbstractDuck model = new ModelDuck();
            model.PerformFly();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.PerformFly();

            Console.ReadKey();
        }
    }
}
