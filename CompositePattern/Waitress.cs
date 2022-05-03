namespace CompositePattern
{
    public class Waitress
    {
        private readonly AbstractMenuComponent _allMenus;

        public Waitress(AbstractMenuComponent allMenus)
        {
            _allMenus = allMenus;
        }

        public void PrintMenu()
        {
            _allMenus.Print();
        }
    }
}
