using System;

namespace FactoryMethodPattern
{
    public class PepperoniPizza : AbstractPizza
    {
        private readonly IPizzaIngredientFactory _ingredientFactory;

        public PepperoniPizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Dough = _ingredientFactory.CreateDough();
            Sauce = _ingredientFactory.CreateSauce();
            Cheese = _ingredientFactory.CreateCheese();
            Pepperoni = _ingredientFactory.CreatePepperoni();

            Console.WriteLine("Preparing " + Name);
            Console.WriteLine(Dough);
            Console.WriteLine(Sauce);
            Console.WriteLine(Cheese);
            Console.WriteLine(Pepperoni);
        }
    }
}
