namespace Test.CodeMaze.Builder
{
    public interface IProductStockReportBuilder
    {
        void BuildHeader();
        void BuildBody();
        void BuildFooter();

        ProductStockReport GetReport();
    }
}
