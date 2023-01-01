namespace Test.CodeMaze.Facade
{
    public class Order
    {
        public string DishName { get; set; }
        public double DishPrice { get; set; }
        public string User { get; set; }
        public string Address { get; set; }
        public double ShippingPrice { get; set; }

        public override string ToString() =>
            $"User: {User}, ordered: {DishName}, should pay {DishPrice + ShippingPrice}";
    }
}
