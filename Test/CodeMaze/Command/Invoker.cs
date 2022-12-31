namespace Test.CodeMaze.Command
{
    public class Invoker
    {
        private ICommand _command;
        public Invoker()
        {

        }

        public void SetCommand(ICommand command) => _command = command;
        public void Invoke()
        {
            _command.Execute();
        }
    }
}
