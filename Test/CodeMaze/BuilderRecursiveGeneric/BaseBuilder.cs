namespace Test.CodeMaze.BuilderRecursiveGeneric
{
    public abstract class BaseBuilder
    {
        protected Car car;
        public BaseBuilder()
        {
            car = new Car();
        }

        public Car Build() => car;
    }
}
