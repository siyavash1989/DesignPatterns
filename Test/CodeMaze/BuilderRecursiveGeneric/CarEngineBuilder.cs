namespace Test.CodeMaze.BuilderRecursiveGeneric
{
    public class CarEngineBuilder<T> : CarModelBuilder<CarEngineBuilder<T>> where T: CarEngineBuilder<T>
    {
        public T SetEngine(string engine)
        {
            car.Engine = engine;
            return (T)this;
        }
    }
}
