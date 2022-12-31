namespace Test.CodeMaze.FactoryMethod
{
    public class FactoryMethodExceuter
    {
        public void Execute()
        {
            var factory = new AirConditioner().ExecuteCreation(Actions.Cooling, 22.5);
            factory.Operate();
        }
    }
}
