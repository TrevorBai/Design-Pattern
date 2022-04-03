using System;
using System.Text;

namespace CommandPattern
{
    public class RemoteControl
    {
        private readonly Action[] _onCommands;
        private readonly Action[] _offCommands;
        private Action _undoCommand;

        private readonly ICommand[] _onCommandsStandard;
        private readonly ICommand[] _offCommandsStandard;
        private ICommand _undoCommandStandard;

        public RemoteControl()
        {
            _onCommands = new Action[7];
            _offCommands = new Action[7];

            _onCommandsStandard = new ICommand[7];
            _offCommandsStandard = new ICommand[7];

            var noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                _onCommands[i] = () => noCommand.Execute();
                _offCommands[i] = () => noCommand.Execute();

                _onCommandsStandard[i] = noCommand;
                _offCommandsStandard[i] = noCommand;
            }
            _undoCommand = () => noCommand.Execute();
            _undoCommandStandard = noCommand;
        }

        public void SetCommand(int slot, Action onCommand, Action offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void SetCommandStandard(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommandsStandard[slot] = onCommand;
            _offCommandsStandard[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            //_onCommands[slot].Invoke();
            //_undoCommand = _onCommands[slot];
            _onCommandsStandard[slot].Execute();
            _undoCommandStandard = _onCommandsStandard[slot];
        }

        public void OffButtonWasPushed(int slot)
        {
            //_offCommands[slot].Invoke();
            //_undoCommand = _offCommands[slot];
            _offCommandsStandard[slot].Execute();
            _undoCommandStandard = _offCommandsStandard[slot];
        }

        public void UndoButtonWasPushed()
        {
            _undoCommandStandard.Undo();
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("\n------ Remote Control -------\n");
            for (int i = 0; i < _onCommandsStandard.Length; i++)
            {
                stringBuilder.Append("[slot " + i + "] " + _onCommandsStandard[i].GetType().Name
                    + "    " + _offCommandsStandard[i].GetType().Name + "\n");
            }
            stringBuilder.Append("[undo] " + _undoCommandStandard.GetType().Name + "\n");
            return stringBuilder.ToString();
        }
    }
}
