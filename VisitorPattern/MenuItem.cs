namespace VisitorPattern
{
    public class MenuItem
    {
        public IState GetState()
        {
            return new GenericState();
        }
    }
}
