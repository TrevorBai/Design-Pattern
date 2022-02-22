namespace DecoratorPattern
{
    public abstract class AbstractBeverage
    {
        public AbstractBeverage()
        {
            Description = "Unknown Beverage";
        }

        public string Description { get; set; }

        public abstract double Cost();
    }
}
