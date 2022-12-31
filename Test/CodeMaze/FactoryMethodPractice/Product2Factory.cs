namespace Test.CodeMaze.FactoryMethodPractice
{
    public class Product2Factory : Factory
    {
        public override ICommon Create()
        {
            return new Product2();
        }
    }
}
