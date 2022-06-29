namespace Remoting
{
    public abstract class AbstractState
    {
        private readonly GumballMachineServer _gumballMachine;

        public AbstractState(GumballMachineServer gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public virtual void InsertQuarter()
        {
        }

        public virtual void EjectQuarter()
        {
        }

        public virtual void TurnCrank()
        {
        }

        public virtual void Dispense()
        {
        }

        public override string ToString()
        {
            return "waiting for quarter";
        }
    }
}
