namespace Test.CodeMaze.Facade
{
    public class ShippingService
    {
        private Order order;

        public void Accept(Order order)
        {
            this.order = order;
        }

        public void CalculateShippingPrice()
        {
            this.order.ShippingPrice = 10.1;
        }

        public void ShipOrder()
        {
            Console.WriteLine(order);
            Console.WriteLine($"Order Ship to {order.Address} \n");
        }
    }
}
