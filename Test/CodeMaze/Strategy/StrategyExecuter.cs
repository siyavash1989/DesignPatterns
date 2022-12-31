namespace Test.CodeMaze.Strategy
{
    public class StrategyExecuter
    {
        public void Execute()
        {
            var strategy = new Walking();
            var context = new StrategyContext(strategy);
            context.Do();
        }
    }
}
