namespace Test.CodeMaze.BuilderRecursive
{
    public class RecursiveExecuter
    {
        public void Execute()
        {
            var builder = new ReportBuilder();
            var director = new StockBuilderDirector(builder);
            director.Build();
            var result = builder.Build();

            Console.WriteLine(result);
        }
    }
}
