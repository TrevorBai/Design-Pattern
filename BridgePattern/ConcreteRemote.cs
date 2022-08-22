using System;

namespace BridgePattern
{
    public class ConcreteRemote : AbstractRemoteControl
    {
        private int _currentStation;

        public ConcreteRemote(AbstractTV TV) : base(TV)
        {
        }

        public override void On()
        {
            throw new NotImplementedException();
        }

        public override void Off()
        {
            throw new NotImplementedException();
        }

        // Could implement other new methods which have
        // not been defined by abstract class due to
        // requirement changes
        public void NextChannel()
        {
            SetChannel(_currentStation + 1);
        }

        public void PreviousChannel()
        {
            SetChannel(_currentStation - 1);
        }

        // More methods
    }
}
