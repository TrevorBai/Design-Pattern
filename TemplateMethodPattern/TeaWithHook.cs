using System;

namespace TemplateMethodPattern
{
    public class TeaWithHook : AbstractCaffeineBeverageWIthHook
    {
        public override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon");
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
