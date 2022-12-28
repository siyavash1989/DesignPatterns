using System.Text;

namespace Test.CodeMaze.Builder
{
    public class ProductStockReport
    {
        public string HeaderPart { get; set; }
        public string BodyPart { get; set; }
        public string FooterPart { get; set; }

        public override string ToString() =>
            new StringBuilder()
            .Append(HeaderPart)
            .Append(BodyPart)
            .Append(FooterPart)
            .ToString();
    }
}
