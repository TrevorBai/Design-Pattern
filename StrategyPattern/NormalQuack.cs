using System;

namespace StrategyPattern
{
    public class NormalQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
