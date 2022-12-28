namespace Test.CodeMaze.BuilderRecursiveGeneric
{
    public class CarDoorBuilder<T> : CarEngineBuilder<CarDoorBuilder<T>> where T: CarDoorBuilder<T>
    {
        public T SetDoors(int doors)
        {
            car.Doors = doors;
            return (T)this;
        }
    }
}
