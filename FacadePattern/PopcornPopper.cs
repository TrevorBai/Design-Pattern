using System;

namespace FacadePattern
{
    public class PopcornPopper
    {
        public string Description { get; set; }

        public void On()
        {
            Console.WriteLine(Description + " on");
        }

        public void Off()
        {
            Console.WriteLine(Description + " off");
        }

        public void Pop()
        {
            Console.WriteLine(Description + " popping popcorn!");
        }
    }
}
