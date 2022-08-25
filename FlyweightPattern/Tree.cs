namespace FlyweightPattern
{
    public class Tree
    {
        //private readonly double _xCoord;
        //private readonly double _yCoord;
        //private readonly double _age;

        public double X { get; set; }
        public double Y { get; set; }
        public double Age { get; set; }

        public void Display(double x, double y, double age)
        {
            // Use X - Y coords
            // & complex age
            // related calcs

            X = x;
            Y = y;
            Age = age;
        }
    }
}
