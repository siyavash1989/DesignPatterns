namespace Test.CodeMaze.Command
{
    public class Product
    {
        public string Title { get; set; }
        public int Price { get; set; }
        public Product(string title, int price)
        {
            Title = title;
            Price = price;
        }

        public void IncreasePrice(int amount)
        {
            Price += amount;
        }

        public void DecresePrice(int amount)
        {
            Price -= amount;
        }

        public override string ToString() => $"product title: {Title}, product price: {Price} \n";
    }

    public enum Actions
    {
        Increase,
        Decrese
    }
}
