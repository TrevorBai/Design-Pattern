using System;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var masterGameObject = new MasterGameObject();
            // When new level is reached
            var saved = masterGameObject.GetCurrentState();

            // When a restore is required
            masterGameObject.RestoreState(saved);

            Console.ReadKey(); 
        }
    }
}
