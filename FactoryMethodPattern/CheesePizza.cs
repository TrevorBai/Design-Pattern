using System;

namespace FactoryMethodPattern
{
    public class CheesePizza : AbstractPizza
    {
        private readonly IPizzaIngredientFactory _ingredientFactory;

        public CheesePizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Dough = _ingredientFactory.CreateDough();
            Sauce = _ingredientFactory.CreateSauce();
            Cheese = _ingredientFactory.CreateCheese();

            Console.WriteLine("Preparing " + Name);
            Console.WriteLine(Dough);
            Console.WriteLine(Sauce);
            Console.WriteLine(Cheese);
        }
    }
}
