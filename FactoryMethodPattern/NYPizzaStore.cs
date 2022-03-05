namespace FactoryMethodPattern
{
    public class NYPizzaStore : AbstractPizzaStore
    {
        public override AbstractPizza CreatePizza(string type)
        {
            AbstractPizza pizza = null;
            IPizzaIngredientFactory nyIngredientFactory = new NYPizzaIngredientFactory();

            if (type.Equals("cheese"))
            {
                pizza = new CheesePizza(nyIngredientFactory)
                {
                    Name = "New York Style Cheese Pizza"
                };
            } else if (type.Equals("veggie"))
            {
                pizza = new VeggiePizza(nyIngredientFactory)
                {
                    Name = "New York Style Veggie Pizza"
                };
            } else if (type.Equals("clam"))
            {
                pizza = new ClamPizza(nyIngredientFactory)
                {
                    Name = "New York Style Clam Pizza"
                };
            } else if (type.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza(nyIngredientFactory)
                {
                    Name = "New York Style Pepperoni Pizza"
                };
            }

            return pizza;
        }
    }
}
