namespace Test.CodeMaze.Composite
{
    public class Composite : Component, IComponent
    {
        private List<Component> _components;
        public Composite(string name, double price) : base(name, price)
        {
            _components = new List<Component>();
        }

        public void Add(Component component)
        {
            _components.Add(component);
        }

        public override double GetPrice()
        {
            double price = 0;
            foreach (Component component in _components)
            {
                price = price + component.GetPrice();
            }
            return price;
        }

        public void Remove(Component component)
        {
            _components.Remove(component);
        }
    }
}
