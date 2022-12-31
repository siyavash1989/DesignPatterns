namespace Test.CodeMaze.FactoryMethod
{
    public class HeatingManager : IAirConditioner
    {
        private readonly double _temperature;

        public HeatingManager(double temperature)
        {
            _temperature = temperature;
        }
        public void Operate()
        {
            Console.WriteLine($"Heating the room to reach {_temperature} degrees \n");
        }
    }
}
