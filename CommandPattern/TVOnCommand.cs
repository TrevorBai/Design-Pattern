namespace CommandPattern
{
    public class TVOnCommand : ICommand
    {
        private readonly TV _TV;

        public TVOnCommand(TV TV)
        {
            _TV = TV;
        }

        public void Execute()
        {
            _TV.On();
            _TV.SetDVD();
        }

        public void Undo()
        {
            _TV.Off();
        }
    }
}
