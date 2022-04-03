namespace CommandPattern
{
    public class CeilingFanHighCommand : ICommand
    {
        private readonly CeilingFan _ceilingFan;
        private int _prevSpeed;

        public CeilingFanHighCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            _prevSpeed = _ceilingFan.GetSpeed();
            _ceilingFan.High();
        }

        public void Undo()
        {
            if (_prevSpeed == CeilingFan.HIGH)
            {
                _ceilingFan.High();
            } else if (_prevSpeed == CeilingFan.MEDIUM)
            {
                _ceilingFan.Medium();
            } else if (_prevSpeed == CeilingFan.LOW)
            {
                _ceilingFan.Low();
            } else if (_prevSpeed == CeilingFan.OFF)
            {
                _ceilingFan.Off();
            }
        }
    }
}
