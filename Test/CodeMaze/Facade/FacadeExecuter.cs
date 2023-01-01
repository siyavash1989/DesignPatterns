namespace Test.CodeMaze.Facade
{
    public class FacadeExecuter
    {
        public void Execute()
        {
            var restaurant = new RestaurantService();
            var shipping = new ShippingService();   
            var facade = new Facade(restaurant, shipping);

            var orders = new List<Order>()
            {
                new Order()
                {
                    Address = "",
                    DishName = "Dish Fish",
                    DishPrice = 120,
                    User = "user 1"
                },
                new Order()
                {
                    Address = "",
                    DishName = "Dish Rice",
                    DishPrice = 40,
                    User = "user 2"
                }
            };
            facade.HandleOrder(orders);
        }
    }
}
