namespace Test.CodeMaze.FactoryMethod
{
    public class HeatingFactory : AirConditionerFactory
    {
        public override IAirConditioner Create(double temperature)
        {
            return new HeatingManager(temperature);
        }
    }
}
