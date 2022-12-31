namespace Test.CodeMaze.Composite
{
    public abstract class Component
    {
        protected string name;
        protected double price;

        public Component(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public abstract double GetPrice();
    }
}
