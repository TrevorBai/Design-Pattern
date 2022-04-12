using System;

namespace FacadePattern
{
    public class Screen
    {
        public string Description { get; set; }

        public void Up()
        {
            Console.WriteLine(Description + " going up");
        }

        public void Down()
        {
            Console.WriteLine(Description + " going down");
        }
    }
}
