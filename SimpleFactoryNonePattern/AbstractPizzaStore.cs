namespace FactoryPattern
{
    public abstract class AbstractPizzaStore
    {
        public AbstractPizza OrderPizza(string type)
        {
            var pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        public abstract AbstractPizza CreatePizza(string type);

        // Other methods here
    }
}
