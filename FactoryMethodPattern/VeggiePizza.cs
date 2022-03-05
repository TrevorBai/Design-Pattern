using System;

namespace FactoryMethodPattern
{
    public class VeggiePizza : AbstractPizza
    {
        private readonly IPizzaIngredientFactory _ingredientFactory;

        public VeggiePizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Dough = _ingredientFactory.CreateDough();
            Sauce = _ingredientFactory.CreateSauce();
            Cheese = _ingredientFactory.CreateCheese();
            Veggies = _ingredientFactory.CreateVeggies();

            Console.WriteLine("Preparing " + Name);
            Console.WriteLine(Dough);
            Console.WriteLine(Sauce);
            Console.WriteLine(Cheese);

            foreach (var veggie in Veggies)
            {
                Console.WriteLine(veggie);
            }
        }
    }
}
