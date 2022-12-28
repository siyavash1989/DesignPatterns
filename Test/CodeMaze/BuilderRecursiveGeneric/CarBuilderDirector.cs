namespace Test.CodeMaze.BuilderRecursiveGeneric
{
    public class CarBuilderDirector : CarDoorBuilder<CarBuilderDirector>
    {
        public static CarBuilderDirector NewCar => new CarBuilderDirector();
    }
}
