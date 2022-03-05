using System;

namespace FactoryMethodPattern
{
    public class ClamPizza : AbstractPizza
    {
        private readonly IPizzaIngredientFactory _ingredientFactory;

        public ClamPizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Dough = _ingredientFactory.CreateDough();
            Sauce = _ingredientFactory.CreateSauce();
            Cheese = _ingredientFactory.CreateCheese();
            Clam = _ingredientFactory.CreateClam();

            Console.WriteLine("Preparing " + Name);
            Console.WriteLine(Dough);
            Console.WriteLine(Sauce);
            Console.WriteLine(Cheese);
            Console.WriteLine(Clam);
        }
    }
}
