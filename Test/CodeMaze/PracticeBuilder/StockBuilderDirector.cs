namespace Test.CodeMaze.PracticeBuilder
{
    public class StockBuilderDirector
    {
        private readonly IStockReportBuilder _stockReportBuilder;

        public StockBuilderDirector(IStockReportBuilder stockReportBuilder)
        {
            _stockReportBuilder = stockReportBuilder;
        }

        public void Build()
        {
            _stockReportBuilder.GetHeader();
            _stockReportBuilder.GetBody();
            _stockReportBuilder.GetFooter();
        }
    }
}
