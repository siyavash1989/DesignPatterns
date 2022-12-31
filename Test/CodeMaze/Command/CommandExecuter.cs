namespace Test.CodeMaze.Command
{
    public class CommandExecuter
    {
        public void Execute()
        {
            var product = new Product("book1", 200);
            var command = new ProductCommand(product, Actions.Increase, 50);
            var invoke = new Invoker();
            invoke.SetCommand(command);
            invoke.Invoke();

            Console.WriteLine(product.ToString());
        }
    }
}
