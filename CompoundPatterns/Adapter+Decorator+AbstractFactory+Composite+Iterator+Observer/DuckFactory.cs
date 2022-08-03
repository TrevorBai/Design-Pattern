namespace CompoundPatterns
{
    public class DuckFactory : AbstractDuckFactory
    {
        public override IQuackable CreateMaqllardDuck()
        {
            return new MallardDuck();
        }

        public override IQuackable CreateRedheadDuck()
        {
            return new RedheadDuck();
        }

        public override IQuackable CreateDuckCall()
        {
            return new DuckCall();
        }

        public override IQuackable CreateRubberDuck()
        {
            return new RubberDuck();
        }

        public override IQuackable CreateGooseDuck()
        {
            return new GooseAdapter(new Goose());
        }
    }
}
