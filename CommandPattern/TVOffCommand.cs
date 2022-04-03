namespace CommandPattern
{
    public class TVOffCommand : ICommand
    {
        private readonly TV _TV;

        public TVOffCommand(TV TV)
        {
            _TV = TV;
        }

        public void Execute()
        {
            _TV.Off();
        }

        public void Undo()
        {
            _TV.On();
        }
    }
}
