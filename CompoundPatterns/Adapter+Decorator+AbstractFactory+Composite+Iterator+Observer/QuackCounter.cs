namespace CompoundPatterns
{
    // A decorator
    // Just a wrapper to add additional behaviors
    public class QuackCounter : IQuackable
    {
        private readonly IQuackable _duck;
        private static int _numberOfQuacks;  // Additional behavior

        public QuackCounter(IQuackable duck)
        {
            _duck = duck;
        }

        public void Quack()
        {
            _duck.Quack();
            _numberOfQuacks++;
        }

        // Additional behavior
        public static int GetQuacks()
        {
            return _numberOfQuacks;
        }

        public void RegisterObserver(IObserver observer)
        {
            _duck.RegisterObserver(observer);
        }

        public void NotifyObservers()
        {
            _duck.NotifyObservers();
        }
    }
}
