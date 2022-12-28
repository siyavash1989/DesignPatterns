namespace Test.CodeMaze.PracticeBuilder
{
    public interface IStockReportBuilder
    {
        void GetHeader();
        void GetBody();
        void GetFooter();

        StockReport Build();
    }
}
