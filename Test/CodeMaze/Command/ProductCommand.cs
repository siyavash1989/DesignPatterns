namespace Test.CodeMaze.Command
{
    public class ProductCommand : ICommand
    {
        private readonly Product _product;
        private readonly Actions _action;
        private readonly int _amount;

        public ProductCommand(Product product, Actions action, int amount)
        {
            _product = product;
            _action = action;
            _amount = amount;
        }
        public void Execute()
        {
            if(_action == Actions.Increase)
            {
                _product.IncreasePrice(_amount);
            }
            else
            {
                _product.DecresePrice(_amount);
            }
        }
    }
}
