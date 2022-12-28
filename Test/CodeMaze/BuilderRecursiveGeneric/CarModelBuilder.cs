namespace Test.CodeMaze.BuilderRecursiveGeneric
{
    public class CarModelBuilder<T> : BaseBuilder where T: CarModelBuilder<T>
    {
        public T SetModel(string model)
        {
            car.Model = model;
            return (T)this;
        }
    }
}
