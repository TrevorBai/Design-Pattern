using System;

namespace StrategyPattern
{
    public class MallardDuck : AbstractDuck
    {
        public MallardDuck()
        {
            quackBehavior = new NormalQuack();
            flyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }
}
