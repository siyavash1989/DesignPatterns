using Test.Builder.Products;

namespace Test.Builder.Builders
{
    public class ApartmentBuilder : IBuilder
    {
        private Product apartmentProduct = new Product();
        public ApartmentBuilder()
        {
            Reset();
        }
        public IBuilder BuidlHouse()
        {
            apartmentProduct.AddPart("House");
            return (IBuilder)apartmentProduct;
        }

        public IBuilder BuildGarden()
        {
            apartmentProduct.AddPart("Garden");
            return (IBuilder)apartmentProduct;
        }

        public IBuilder BuildParking()
        {
            apartmentProduct.AddPart("Parking");
            return (IBuilder)apartmentProduct;
        }

        public IBuilder BuildPool()
        {
            apartmentProduct.AddPart("Pool");
            return (IBuilder)apartmentProduct;
        }

        public void Reset()
        {
            apartmentProduct = new Product();
        }
    }
}
