using System;

namespace TemplateMethodPattern
{
    public abstract class AbstractCaffeineBeverageWIthHook
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }
        }

        public abstract void Brew();

        public abstract void AddCondiments();

        public void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        public void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        public virtual bool CustomerWantsCondiments()
        {
            return true;
        }

        public string GetUserInput()
        {
            string answer = null;
            Console.WriteLine("Would you like milk and sugar with your coffee (y/n)? ");
            answer = Console.ReadLine();
            if (answer == null) return "no";
            return answer;
        }

    }
}
