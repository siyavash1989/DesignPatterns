namespace Test.CodeMaze.BuilderRecursive
{
    public interface IReportBuilder
    {
        IReportBuilder SetHeader();
        IReportBuilder SetBody();
        IReportBuilder SetFooter();

        StockReport Build();
    }
}
