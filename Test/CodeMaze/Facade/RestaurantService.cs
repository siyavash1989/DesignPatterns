namespace Test.CodeMaze.Facade
{
    public class RestaurantService
    {
        private List<Order> _orders;
        public RestaurantService()
        {
            _orders = new List<Order>();
        }

        public void AddToCart(Order order)
        {
            _orders.Add(order);
        }

        public void CompeleteOrder()
        {
            Console.WriteLine("Order Compeleted. \n");
        }
    }
}
