using System;

namespace DynamicProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Drive();
            Console.ReadKey();
        }

        public void MatchMakingTestDrive()
        {
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            // Initialize database here
            // ...
        }

        public static void Drive()
        {
            var joe = GetPersonFromDatabase("Joe CShapebean");

            // Owner proxy
            var ownerProxy = GetOwnerProxy(joe);
            Console.WriteLine("Name is " + ownerProxy.GetName());
            ownerProxy.Interests = "bowling, Go";
            Console.WriteLine("Interests set from owner proxy");
            try
            {
                ownerProxy.Rating = 10;
            } catch (Exception e)
            {
                Console.WriteLine("Can't set rating from owner proxy");
            }
            Console.WriteLine("Rating is " + ownerProxy.GetGeekRating());
            Console.WriteLine("");

            // None Owner Proxy
            var nonOwnerProxy = GetNonOwnerProxy(joe);
            Console.WriteLine("Name is " + nonOwnerProxy.GetName());
            try
            {
                nonOwnerProxy.Interests = "bowling, Go";
            } catch (Exception e)
            {
                Console.WriteLine("Can't set interests from non owner proxy");
            }
            nonOwnerProxy.Rating = 3;
            Console.WriteLine("Rating set from non owner proxy");
            Console.WriteLine("Rating is " + nonOwnerProxy.GetGeekRating());
        }

        private static IPerson GetPersonFromDatabase(string name)
        {
            var person = new Person();
            person.SetName(name);
            person.SetGeekRating(7);
            return person;
        }

        private static dynamic GetOwnerProxy(IPerson person)
        {
            dynamic ownerProxy = new OwnerInvocationHandler(person);
            return ownerProxy;
        }

        private static dynamic GetNonOwnerProxy(IPerson person)
        {
            dynamic nonOwnerProxy = new NonOwnerInvocationHandler(person);
            return nonOwnerProxy;
        }
    }
}
