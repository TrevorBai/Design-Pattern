namespace DecoratorPattern
{
    public class Mocha : AbstractCondimentDecorator
    {
        public Mocha(AbstractBeverage beverage)
        {
            Beverage = beverage;
            Description = beverage.Description + ", Mocha";
        }

        public override double Cost()
        {
            return Beverage.Cost() + .20;
        }
    }
}
