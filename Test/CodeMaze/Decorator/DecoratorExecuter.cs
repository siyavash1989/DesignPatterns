namespace Test.CodeMaze.Decorator
{
    public class DecoratorExecuter
    {
        public void Execute()
        {
            var defInstance = new DefaultComponent();
            var sampleDecorator = new SampleDecorator(defInstance);
            sampleDecorator.Operate();
        }
    }
}
