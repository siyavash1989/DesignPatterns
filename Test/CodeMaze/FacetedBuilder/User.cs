using System.Text;

namespace Test.CodeMaze.FacetedBuilder
{
    public class User
    {
        //Info
        public string Name { get; set; }
        public string Family { get; set; }
        public int Age { get; set; }

        //Address
        public string Province { get; set; }
        public string City { get; set; }


        public override string ToString() =>
            new StringBuilder()
            .Append(Name)
            .Append(Family)
            .Append(Age)
            .Append(Province)
            .Append(City)
            .ToString();
    }
}
