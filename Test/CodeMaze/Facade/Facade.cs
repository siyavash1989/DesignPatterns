namespace Test.CodeMaze.Facade
{
    public class Facade
    {
        private readonly RestaurantService restaurantService;
        private readonly ShippingService shippingService;

        public Facade(RestaurantService restaurantService, ShippingService shippingService)
        {
            this.restaurantService = restaurantService;
            this.shippingService = shippingService;
        }

        public void HandleOrder(List<Order> orders)
        {
            foreach (var order in orders)
            {
                this.restaurantService.AddToCart(order);
            }
           
            this.restaurantService.CompeleteOrder();

            foreach (var order in orders)
            {
                this.shippingService.Accept(order);
                this.shippingService.CalculateShippingPrice();
                this.shippingService.ShipOrder();
            }
           
        }
    }
}
