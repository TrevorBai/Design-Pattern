using System;
using System.Text;

namespace StatePattern
{
    public class GumballMachine
    {
        private readonly IState _soldOutState;
        private readonly IState _noQuarterState;
        private readonly IState _hasQuarterState;
        private readonly IState _soldState;
        private readonly IState _winnerState;

        private IState _state;
        private int _count = 0;

        public GumballMachine(int numberGumballs)
        {
            _soldOutState = new SoldOutState(this);
            _noQuarterState = new NoQuarterState(this);
            _hasQuarterState = new HasQuarterState(this);
            _soldState = new SoldState(this);
            _winnerState = new WinnerState(this);

            _count = numberGumballs;
            if (numberGumballs > 0)
            {
                _state = _noQuarterState;
            } else
            {
                _state = _soldOutState;
            }
        }

        public int GetCount()
        {
            return _count;
        }

        public IState GetHasQuarterState()
        {
            return _hasQuarterState;
        }

        public IState GetNoQuarterState()
        {
            return _noQuarterState;
        }

        public IState GetSoldState()
        {
            return _soldState;
        }

        public IState GetSoldOutState()
        {
            return _soldOutState;
        }

        public IState GetWinnerState()
        {
            return _winnerState;
        }

        public void InsertQuarter()
        {
            _state.InsertQuarter();
        }

        public void EjectQuarter()
        {
            _state.InsertQuarter();
        }

        public void TurnCrank()
        {
            _state.TurnCrank();
            _state.Dispense();
        }

        public void SetState(IState state)
        {
            _state = state;
        }     

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append("\nMighty Gumball, Inc.");
            result.Append("\nC#-Enabled Standing Gumball Model #2022\n");
            if (_count < 1)
            {
                result.Append("Inventory: " + _count + " gumballs\n");
                result.Append("Machine is sold out");
            }
            else if (_count == 1)
            {
                result.Append("Inventory: " + _count + " gumball\n");
                result.Append("Machine is waiting for quarter\n");
            }
            else
            {
                result.Append("Inventory: " + _count + " gumballs\n");
                result.Append("Machine is waiting for quarter\n");
            }

            return result.ToString();
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (_count > 0) _count--;
        }

        public void Refill(int count)
        {
            _count += count;
            Console.WriteLine("The gumball machine was just refilled; its new count is: " + _count);
            _state.Refill();
        }
    }
}
