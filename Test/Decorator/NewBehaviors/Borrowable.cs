using Test.Decorator.Decorator;

namespace Test.Decorator.NewBehaviors
{
    public class Borrowable : MyDecorator
    {
        public Borrowable(LibrayItem librayItem) : base(librayItem)
        {
        }

        public override void Display()
        {
            base.Display();
            //Do something new
        }

        public void Borrow()
        {
            //do something in additon
        }
    }
}
