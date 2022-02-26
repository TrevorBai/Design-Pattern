namespace FactoryPattern
{
    public class NYPizzaStore : AbstractPizzaStore
    {
        public override AbstractPizza CreatePizza(string type)
        {
            if (type.Equals("cheese"))
            {
                return new NYStyleCheesePizza();
            } else if (type.Equals("veggie"))
            {
                return new NYStyleVeggiePizza();
            } else if (type.Equals("clam"))
            {
                return new NYStyleClamPizza();
            } else if (type.Equals("pepperoni"))
            {
                return new NYStylePepperoniPizza();
            } else
            {
                return null;
            }
        }
    }
}
