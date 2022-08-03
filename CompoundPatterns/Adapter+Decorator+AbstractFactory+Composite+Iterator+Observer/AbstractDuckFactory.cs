namespace CompoundPatterns
{
    public abstract class AbstractDuckFactory
    {
        public abstract IQuackable CreateMaqllardDuck();
        public abstract IQuackable CreateRedheadDuck();
        public abstract IQuackable CreateDuckCall();
        public abstract IQuackable CreateRubberDuck();
        public abstract IQuackable CreateGooseDuck();
    }
}
