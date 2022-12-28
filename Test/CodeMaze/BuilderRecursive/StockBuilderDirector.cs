namespace Test.CodeMaze.BuilderRecursive
{
    public class StockBuilderDirector
    {
        private readonly IReportBuilder _reportBuilder;

        public StockBuilderDirector(IReportBuilder reportBuilder)
        {
            _reportBuilder = reportBuilder;
        }
        public void Build()
        {
            _reportBuilder.SetHeader()
                .SetBody()
                .SetFooter();
        }
    }
}
