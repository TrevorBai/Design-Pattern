namespace CompoundPatterns
{
    public class CountingDuckFactory : AbstractDuckFactory
    {
        public override IQuackable CreateMaqllardDuck()
        {
            return new QuackCounter(new MallardDuck());
        }

        public override IQuackable CreateRedheadDuck()
        {
            return new QuackCounter(new RedheadDuck());
        }

        public override IQuackable CreateDuckCall()
        {
            return new QuackCounter(new DuckCall());
        }

        public override IQuackable CreateRubberDuck()
        {
            return new QuackCounter(new RubberDuck());
        }

        public override IQuackable CreateGooseDuck()
        {
            // Goose duck quack doesn't count
            // So remove QuackCounter wrapper
            return new GooseAdapter(new Goose());
        }
    }
}
