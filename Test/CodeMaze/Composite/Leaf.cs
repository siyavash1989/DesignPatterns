namespace Test.CodeMaze.Composite
{
    public class Leaf : Component
    {
        public Leaf(string name, double price) : base(name, price)
        {
        }

        public override double GetPrice()
        {
            return this.price;
        }
    }
}
