namespace Test.CodeMaze.FactoryMethod
{
    public class CoolingManager : IAirConditioner
    {
        private readonly double _temperature;

        public CoolingManager(double temperature)
        {
            _temperature = temperature;
        }
        public void Operate()
        {
            Console.WriteLine($"Cooling the room to reach temp: {_temperature} degrees \n");
        }
    }
}
