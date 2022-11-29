namespace Test.Strategy.Context
{
    public class StrategyContext
    {
        private readonly IStrategy _strategy;

        public StrategyContext(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public string DoStrategy(int a, int b)
        {
            return _strategy.CalculatePath(a, b);
        }
    }
}
