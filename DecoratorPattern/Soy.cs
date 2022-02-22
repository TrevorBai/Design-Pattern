namespace DecoratorPattern
{
    public class Soy : AbstractCondimentDecorator
    {
        public Soy(AbstractBeverage beverage)
        {
            Beverage = beverage;
            Description = beverage.Description + ", Soy";
        }

        public override double Cost()
        {
            return Beverage.Cost() + .15;
        }

    }
}
