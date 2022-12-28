using System.Text;

namespace Test.CodeMaze.BuilderRecursiveGeneric
{
    public class Car
    {
        public string Model { get; set; }
        public int Doors { get; set; }
        public string Engine { get; set; }

        public override string ToString()=>
            new StringBuilder()
            .Append(Model)
            .Append(Engine)
            .Append(Doors.ToString())
            .ToString();
    }
}
