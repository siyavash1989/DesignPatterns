using System.Text;

namespace Test.CodeMaze.PracticeBuilder
{
    public class StockReport
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public string Footer { get; set; }

        public override string ToString() =>
            new StringBuilder()
                .Append(Header)
                .Append(Body)
                .Append(Footer).ToString();

    }
}
