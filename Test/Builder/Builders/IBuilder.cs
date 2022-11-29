namespace Test.Builder.Builders
{
    public interface IBuilder
    {
        public void Reset();
        public IBuilder BuidlHouse();
        public IBuilder BuildPool();
        public IBuilder BuildGarden();
        public IBuilder BuildParking();
    }
}
