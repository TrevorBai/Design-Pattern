using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    class StrategyPattern1
    {
        static void Main(string[] args)
        {
            // Favor composition
            // Dependancy injection
            var wildDuck = new Duck("wild", new WildWalkBehavior(), new WildFlyBehavior());
            var cityDuck = new Duck("city", new CalmWalkBehavior(), new CalmFlyBehavior());
            var mountainDuck = new Duck("mountain", new CalmWalkBehavior(), new HighAltitudeFlyBehavior());
            var cloudDuck = new Duck("cloud", new NoWalkBehavior(), new HighAltitudeFlyBehavior());

            var duckLists = new List<Duck>()
            {
                wildDuck,
                cityDuck,
                mountainDuck,
                cloudDuck
            };

            foreach (var duck in duckLists)
            {
                Console.WriteLine();
                Console.WriteLine("Walking: " + duck.GetName() + " => " + duck.Walk());
                Console.WriteLine("Flying: " + duck.GetName() + " => " + duck.Fly());
            }

            Console.ReadKey();
        }

        // The common/normal way of writing code
        #region Common way

        interface IDuck
        {
            string Walk();
            string Fly();
        }

        class WildDuck : IDuck
        {
            public string Fly()
            {
                return "Seriously wild flying";
            }

            public string Walk()
            {
                return "Walking wildly";
            }
        }

        class CityDuck : IDuck
        {
            public string Fly()
            {
                return "High-intensity flying";
            }

            public string Walk()
            {
                return "Walking casually";
            }
        }

        class MountainDuck : IDuck
        {
            public string Fly()
            {
                return "High-altitude flying";
            }

            // Same as CityDuck walk
            public string Walk()
            {
                return "Walking casually";
            }
        }

        class CloudDuck : IDuck
        {
            // Same as MountainDuck fly
            public string Fly()
            {
                return "High-altitude flying";
            }

            public string Walk()
            {
                return "No walking";
            }

        }

        #endregion

        #region Strategy Pattern

        // ###################################################
        // Walk behavior
        interface IWalkBehavior
        {
            string Walk();
        }

        class WildWalkBehavior : IWalkBehavior
        {
            public string Walk()
            {
                return "Walking wildly";
            }
        }

        class CalmWalkBehavior : IWalkBehavior
        {
            public string Walk()
            {
                return "Walking casually";
            }
        }

        class NoWalkBehavior : IWalkBehavior
        {
            public string Walk()
            {
                return "No walking";
            }
        }

        // ###################################################
        // Fly behavior
        interface IFlyBehavior
        {
            string Fly();
        }

        class WildFlyBehavior : IFlyBehavior
        {
            public string Fly()
            {
                return "Seriously wild flying";
            }
        }

        class CalmFlyBehavior : IFlyBehavior
        {
            public string Fly()
            {
                return "High-intensity flying";
            }
        }

        class HighAltitudeFlyBehavior : IFlyBehavior
        {
            public string Fly()
            {
                return "High-altitude flying";
            }
        }

        class Duck
        {
            private readonly string _name;
            private IWalkBehavior _walkBehavior;
            private IFlyBehavior _flyBehavior;

            public Duck(string name, IWalkBehavior wb, IFlyBehavior fb)
            {
                _name = name;
                _walkBehavior = wb;
                _flyBehavior = fb;
            }

            public string GetName()
            {
                return _name;
            }

            public string Fly()
            {
                return _flyBehavior.Fly();
            }

            public string Walk()
            {
                return _walkBehavior.Walk();
            }
        }

        #endregion

    }
}
