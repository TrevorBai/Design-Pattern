namespace VisitorPattern
{
    public class Visitor
    {
        // Visitor will traverse the tree with the help of
        // Traverser

        // Can add some new methods for the client to use
        public object GetHealthRating()
        {
            return new object();
        }

        public object GetCalories()
        {
            return new object();
        }

        public object GetProtein()
        {
            return new object();
        }

        public object GetCarbs()
        {
            return new object();
        }
    }
}
