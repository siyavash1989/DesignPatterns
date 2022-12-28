namespace Test.CodeMaze.BuilderRecursiveGeneric
{
    public class GenericExecuter
    {
        public void Execute()
        {
            var car = CarBuilderDirector.NewCar
                .SetModel("BMW X6")
                .SetEngine(" 8 cylender")
                .SetDoors(4)
                .Build();

            Console.WriteLine(car);
        }
    }
}
