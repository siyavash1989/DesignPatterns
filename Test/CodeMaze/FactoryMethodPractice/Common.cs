namespace Test.CodeMaze.FactoryMethodPractice
{
    public class Common
    {
        private readonly Dictionary<Actions, Factory> _factories;
        public Common()
        {
            _factories = new Dictionary<Actions, Factory>();
            foreach (Actions action in Enum.GetValues(typeof(Actions)))
            {
                var factory = (Factory)Activator.CreateInstance(Type.GetType("Test.CodeMaze.FactoryMethodPractice." + Enum.GetName(typeof(Actions), action) + "Factory"));
                _factories.Add(action, factory);
            }
        }

        public ICommon CreateInstance(Actions action)
        {
            return _factories[action].Create();
        }
    }

    public enum Actions
    {
        Product1,
        Product2
    }
}
