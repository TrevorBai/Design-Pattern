namespace FactoryMethodPattern
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public IDough CreateDough()
        {
            return new ThickCrustDough();
        }

        public ISauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public ICheese CreateCheese()
        {
            return new Mozzerella();
        }

        public IVeggies[] CreateVeggies()
        {
            IVeggies[] veggies = { new BlackOlives(), new Spinach(), new EggPlant() };
            return veggies;
        }

        public IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public IClams CreateClam()
        {
            return new FrozenClams();
        }
    }
}
