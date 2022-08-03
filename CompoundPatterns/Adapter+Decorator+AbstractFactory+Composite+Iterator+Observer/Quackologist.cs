using System;

namespace CompoundPatterns
{
    public class Quackologist : IObserver
    {
        public void Update(IQuackObservable duck)
        {
            Console.WriteLine("Quackologist: " + duck + " just quacked.");
        }

    }
}
