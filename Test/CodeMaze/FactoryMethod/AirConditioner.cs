namespace Test.CodeMaze.FactoryMethod
{
    public class AirConditioner
    {
        private readonly Dictionary<Actions, AirConditionerFactory> _factories;
        public AirConditioner()
        {
            _factories = new Dictionary<Actions, AirConditionerFactory>
            {
                { Actions.Cooling, new CoolingFactory() },
                { Actions.Heating, new HeatingFactory() }
            };
        }

        public IAirConditioner ExecuteCreation(Actions action, double temp)
        {
            return _factories[action].Create(temp);
        }
    }
}
