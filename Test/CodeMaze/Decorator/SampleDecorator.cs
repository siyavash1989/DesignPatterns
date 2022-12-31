namespace Test.CodeMaze.Decorator
{
    public class SampleDecorator : Decorator
    {
        public SampleDecorator(BaseComponent baseComponent) : base(baseComponent)
        {
        }

        public override void Operate()
        {
            base.Operate();
            Console.WriteLine("Sample Decorator");
        }
    }
}
