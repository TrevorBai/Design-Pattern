namespace CommandPattern
{
    public class HottubOffCommand : ICommand
    {
        private readonly Hottub _hottub;

        public HottubOffCommand(Hottub hottub)
        {
            _hottub = hottub;
        }

        public void Execute()
        {
            _hottub.Off();
            _hottub.SetTemperature(98);
            _hottub.Cool();
        }

        public void Undo()
        {
            _hottub.On();
        }
    }
}
