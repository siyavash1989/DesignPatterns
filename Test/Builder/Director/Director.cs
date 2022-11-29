using Test.Builder.Builders;

namespace Test.Builder.Director
{
    public class MyDirector
    {
        private IBuilder _builder;
        public IBuilder Builder
        {
            set { _builder = value; }
        }

        public void BuildMinimalHouse()
        {
            _builder.BuidlHouse().BuildGarden().BuildPool().BuildParking();
        }

        public void BuildFullHouse()
        {
            _builder.BuidlHouse().BuildParking();
        }
    }
}
