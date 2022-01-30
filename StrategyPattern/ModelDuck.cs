using System;

namespace StrategyPattern
{
    public class ModelDuck : AbstractDuck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new NormalQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}
