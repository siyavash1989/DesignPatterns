namespace Test.CodeMaze.Decorator
{
    public class Decorator : BaseComponent
    {
        protected readonly BaseComponent baseComponent;

        public Decorator(BaseComponent baseComponent)
        {
            this.baseComponent = baseComponent;
        }
        public override void Operate()
        {
            this.baseComponent.Operate();
        }
    }
}
