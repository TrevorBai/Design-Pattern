namespace CompoundPatterns
{
    // A goose adpater
    public class GooseAdapter : IQuackable
    {
        private readonly Observable _observable;
        private readonly Goose _goose;

        public GooseAdapter(Goose goose)
        {
            _goose = goose;
            _observable = new Observable(this);
        }

        public void Quack()
        {
            _goose.Honk();
            NotifyObservers();
        }

        public override string ToString()
        {
            return "Goose pretending to be a Duck";
        }

        public void RegisterObserver(IObserver observer)
        {
            _observable.RegisterObserver(observer);
        }

        public void NotifyObservers()
        {
            _observable.NotifyObservers();
        }
    }
}
