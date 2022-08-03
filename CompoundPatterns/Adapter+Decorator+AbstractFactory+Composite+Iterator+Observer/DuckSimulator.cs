using System;

namespace CompoundPatterns
{
    public class DuckSimulator
    {
        public void Simulate(AbstractDuckFactory duckFactory)
        {
            var mallardDuck = duckFactory.CreateMaqllardDuck();
            var redheadDuck = duckFactory.CreateRedheadDuck();
            var duckCall = duckFactory.CreateDuckCall();
            var rubberDuck = duckFactory.CreateRubberDuck();
            var gooseDuck = duckFactory.CreateGooseDuck();

            //Console.WriteLine("\nDuck Simulator: With Composite - Flocks");

            var flockOfDucks = new Flock();

            flockOfDucks.Add(redheadDuck);
            flockOfDucks.Add(duckCall);
            flockOfDucks.Add(rubberDuck);
            flockOfDucks.Add(gooseDuck);

            var flockOfMallards = new Flock();

            var mallardOne = duckFactory.CreateMaqllardDuck();
            var mallardTwo = duckFactory.CreateMaqllardDuck();
            var mallardThree = duckFactory.CreateMaqllardDuck();
            var mallardFour = duckFactory.CreateMaqllardDuck();

            flockOfMallards.Add(mallardOne);
            flockOfMallards.Add(mallardTwo);
            flockOfMallards.Add(mallardThree);
            flockOfMallards.Add(mallardFour);

            flockOfDucks.Add(flockOfMallards);

            Console.WriteLine("\nDuck Simulator: With Observer");

            var quackologist = new Quackologist();
            flockOfDucks.RegisterObserver(quackologist);

            Simulate(flockOfDucks);

            //Console.WriteLine("\nDuck Simulator: Mallard Flock Simulation");
            //Simulate(flockOfMallards);

            Console.WriteLine("The ducks quacked " + QuackCounter.GetQuacks() + " times.");
        }

        private void Simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}
