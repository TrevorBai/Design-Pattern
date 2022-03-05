using System;

namespace FactoryMethodPattern
{
    public class ChicagoPizzaStore : AbstractPizzaStore
    {
        public override AbstractPizza CreatePizza(string type)
        {
            AbstractPizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();

            if (type.Equals("cheese"))
            {
                pizza = new CheesePizza(ingredientFactory)
                {
                    Name = "Chicago Style Cheese Pizza"
                };
            }
            else if (type.Equals("veggie"))
            {
                pizza = new VeggiePizza(ingredientFactory)
                {
                    Name = "Chicago Style Veggie Pizza"
                };
            }
            else if (type.Equals("clam"))
            {
                pizza = new ClamPizza(ingredientFactory)
                {
                    Name = "Chicago Style Clam Pizza"
                };
            }
            else if (type.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza(ingredientFactory)
                {
                    Name = "Chicago Style Pepperoni Pizza"
                };
            }

            return pizza;
        }
    }
}
