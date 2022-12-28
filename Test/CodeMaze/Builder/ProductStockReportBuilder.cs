namespace Test.CodeMaze.Builder
{
    public class ProductStockReportBuilder : IProductStockReportBuilder
    {
        private readonly IEnumerable<Product> _products;
        private ProductStockReport _productStockReport;

        public ProductStockReportBuilder(IEnumerable<Product> products)
        {
            _products = products;
            _productStockReport = new ProductStockReport();
        }
        public void BuildBody()
        {
            _productStockReport.BodyPart = string.Join(Environment.NewLine, _products.Select(p => $" product name: {p.Name} - price: {p.Price} \n"));
        }

        public void BuildFooter()
        {
            _productStockReport.FooterPart = $"\nFooter at {DateTime.Now}";
        }

        public void BuildHeader()
        {
            _productStockReport.HeaderPart = $"Header at {DateTime.Now} \n";
        }

        public ProductStockReport GetReport()
        {
            var productStockReport = _productStockReport;
            Clear();
            return productStockReport;
        }

        private void Clear() => _productStockReport = new ProductStockReport();
    }
}
