using Test.Builder.Builders;
using Test.Builder.Director;

namespace Test.Builder.Program
{
    public class Main
    {
        public void BuilderMain()
        {
            var director = new MyDirector();
            var builder = new ApartmentBuilder();    
            director.Builder = builder;


        }
    }
}
