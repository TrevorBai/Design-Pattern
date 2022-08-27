namespace VisitorPattern
{
    public class Menu
    {
        // It is a composite class
        // It could be a tree root node

        public IState GetState()
        {
            return new GenericState();
        }
    }
}
