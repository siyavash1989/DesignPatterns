namespace Test.CodeMaze.FactoryMethodPractice
{
    public class Product1Factory : Factory
    {
        public override ICommon Create()
        {
            return new Product1();
        }
    }
}
