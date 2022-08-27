namespace VisitorPattern
{
    public class Ingredient
    {
        public IState GetState()
        {
            return new GenericState();
        }
    }
}
