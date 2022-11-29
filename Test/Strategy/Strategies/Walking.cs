namespace Test.Strategy.Strategies
{
    public class Walking : IStrategy
    {
        public string CalculatePath(int a, int b)
        {
            return "Walking";
        }
    }
}
