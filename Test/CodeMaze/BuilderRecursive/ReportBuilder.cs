namespace Test.CodeMaze.BuilderRecursive
{
    public class ReportBuilder : IReportBuilder
    {
        private StockReport _stockReport;
        public ReportBuilder()
        {
            _stockReport = new StockReport();
        }
        public StockReport Build()
        {
            var stock = _stockReport;
            Reset();
            return stock;   
        }

        public IReportBuilder SetBody()
        {
            _stockReport.Body = string.Join(Environment.NewLine, "THIS IS MY Body");
            return this;
        }

        public IReportBuilder SetFooter()
        {
            _stockReport.Footer = "\n Footer is printed";
            return this;
        }

        public IReportBuilder SetHeader()
        {
            _stockReport.Header = $"Header at {DateTime.Now} \n";
            return this;
        }

        private void Reset() => _stockReport = new StockReport();
    }
}
