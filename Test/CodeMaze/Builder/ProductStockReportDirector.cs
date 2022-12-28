namespace Test.CodeMaze.Builder
{
    public class ProductStockReportDirector
    {
        private readonly IProductStockReportBuilder _productStockReportBuilder;

        public ProductStockReportDirector(IProductStockReportBuilder productStockReportBuilder)
        {
            _productStockReportBuilder = productStockReportBuilder;
        }

        public void BuildReport()
        {
            _productStockReportBuilder.BuildHeader();
            _productStockReportBuilder.BuildBody();
            _productStockReportBuilder.BuildFooter();   
        }

        public void BuildReportWithoutHeader()
        {
            _productStockReportBuilder.BuildBody();
            _productStockReportBuilder.BuildFooter();
        }
    }
}
