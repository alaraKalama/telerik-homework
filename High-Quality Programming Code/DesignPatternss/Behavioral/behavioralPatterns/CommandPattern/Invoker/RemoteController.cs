namespace CommandPattern.Invoker
{
    using CommandPattern.AbstractCommand;
    using System.Collections.Generic;

    public class RemoteController
    {
        private IList<ICommand> turnOnCommands = new List<ICommand>();
        private IList<ICommand> turnOffCommands = new List<ICommand>();

        public void InsertNewOnCommand(ICommand onCommand)
        {
            turnOnCommands.Add(onCommand);
        }

        public void InsertNewOffCommand(ICommand offCommand)
        {
            turnOffCommands.Add(offCommand);
        }

        public void pressON(int btnNumber)
        {
            turnOnCommands[btnNumber].Execute();
        }

        public void pressOFF(int btnNumber)
        {
            turnOffCommands[btnNumber].Execute();
        }
    }
}