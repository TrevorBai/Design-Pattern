using System.Collections.Generic;

namespace CompoundPatterns
{
    public class Observable : IQuackObservable
    {
        private readonly List<IObserver> _observers = new List<IObserver>();
        private readonly IQuackObservable _duck;

        public Observable(IQuackObservable duck)
        {
            _duck = duck;
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void NotifyObservers()
        {
            _observers.ForEach(observer =>
            {
                observer.Update(_duck);
            });
        }

    }
}
