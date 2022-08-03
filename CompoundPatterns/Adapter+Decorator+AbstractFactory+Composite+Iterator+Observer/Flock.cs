using System.Collections.Generic;

namespace CompoundPatterns
{
    // Composite pattern
    public class Flock : IQuackable
    {
        private readonly Observable _observable;
        private readonly List<IQuackable> _quackers = new List<IQuackable>();

        public Flock()
        {
            _observable = new Observable(this);
        }

        public void Add(IQuackable quacker)
        {
            _quackers.Add(quacker);
        }

        public void Quack()
        {
            _quackers.ForEach(quacker =>
            {
                quacker.Quack();
            });
        }

        public void RegisterObserver(IObserver observer)
        {
            // Add the same observer for each quacker
            // Even though the quacker is a composite quacker
            // i.e. a quacker which is composed of multi quackers
            _quackers.ForEach(quacker =>
            {
                quacker.RegisterObserver(observer);
            });
        }

        // Delegate to each IQuackable in the Flock
        // So do nothing here
        public void NotifyObservers() { }
    }
}
