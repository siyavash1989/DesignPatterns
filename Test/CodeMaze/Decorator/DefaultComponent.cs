namespace Test.CodeMaze.Decorator
{
    public class DefaultComponent : BaseComponent
    {
        public override void Operate()
        {
            Console.WriteLine("Default component operation");
        }
    }
}
