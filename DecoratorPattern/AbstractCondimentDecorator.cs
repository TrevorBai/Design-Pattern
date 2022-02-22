namespace DecoratorPattern
{
    public abstract class AbstractCondimentDecorator : AbstractBeverage
    {
        // Provide a reference to wrapping beverage
        // AbstractCondimentDecorator IS an AbstractBeverage and HAS an AbstractBeverage as well
        public AbstractBeverage Beverage;
    }
}
