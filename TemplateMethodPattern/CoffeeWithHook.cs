using System;

namespace TemplateMethodPattern
{
    public class CoffeeWithHook : AbstractCaffeineBeverageWIthHook
    {
        public override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        public override bool CustomerWantsCondiments()
        {
            var answer = GetUserInput();

            if (answer.ToLower().StartsWith("y"))
            {
                return true;
            }

            return false;
        }
    }
}
