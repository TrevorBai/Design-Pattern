using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var gumballMachine = new GumballMachine(5);

            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine(gumballMachine);

            //gumballMachine.InsertQuarter();
            //gumballMachine.TurnCrank();
            //gumballMachine.InsertQuarter();
            //gumballMachine.TurnCrank();
            //gumballMachine.EjectQuarter();

            //Console.WriteLine(gumballMachine);

            //gumballMachine.InsertQuarter();
            //gumballMachine.InsertQuarter();
            //gumballMachine.TurnCrank();
            //gumballMachine.InsertQuarter();
            //gumballMachine.TurnCrank();
            //gumballMachine.InsertQuarter();
            //gumballMachine.TurnCrank();

            //Console.WriteLine(gumballMachine);

            Console.ReadKey();
        }
    }
}
