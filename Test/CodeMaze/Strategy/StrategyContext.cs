namespace Test.CodeMaze.Strategy
{
    public class StrategyContext
    {
        private readonly IStrategy strategy;

        public StrategyContext(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void Do()
        {
            this.strategy.Transfer();
        }
    }
}
