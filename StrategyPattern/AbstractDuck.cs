using System;

namespace StrategyPattern
{
    public abstract class AbstractDuck
    {
        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;

        // Default constructor
        public AbstractDuck()
        {
        }

        public void SetFlyBehavior(IFlyBehavior fb)
        {
            flyBehavior = fb;
        }

        public void SetQuackBehavior(IQuackBehavior qb)
        {
            quackBehavior = qb;
        }

        public abstract void Display();

        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            quackBehavior.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }

    }
}
