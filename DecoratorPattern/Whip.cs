namespace DecoratorPattern
{
    public class Whip: AbstractCondimentDecorator
    {
        public Whip(AbstractBeverage beverage)
        {
            Beverage = beverage;
            Description = beverage.Description + ", Whip";
        }

        public override double Cost()
        {
            return Beverage.Cost() + .10;
        }

    }
}
