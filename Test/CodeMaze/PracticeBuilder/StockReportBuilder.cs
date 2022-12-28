namespace Test.CodeMaze.PracticeBuilder
{
    public class StockReportBuilder : IStockReportBuilder
    {
        private readonly IEnumerable<Product> _products;
        private StockReport _stockReport;

        public StockReportBuilder(IEnumerable<Product> products)
        {
            _products = products;
            _stockReport = new StockReport();
        }

        

        public void GetBody()
        {
            _stockReport.Body = string.Join(Environment.NewLine, _products.Select(p => $"product: {p.Title} + Id: {p.Id}"));
        }

        public void GetFooter()
        {
            _stockReport.Footer = $"Put Footer at the end of report";
        }

        public void GetHeader()
        {
            _stockReport.Header = $"Put header at {DateTime.Now}";
        }
        public StockReport Build()
        {
            var stock = _stockReport;
            Reset();
            return stock;
        }

        private void Reset() => _stockReport = new StockReport();
    }
}
