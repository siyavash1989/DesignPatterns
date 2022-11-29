namespace Test.Decorator.Decorator
{
    public class MyDecorator : LibrayItem
    {
        protected LibrayItem librayItem;

        public MyDecorator(LibrayItem librayItem)
        {
            this.librayItem = librayItem;
        }
        public override void Display()
        {
            librayItem.Display();
        }
    }
}
