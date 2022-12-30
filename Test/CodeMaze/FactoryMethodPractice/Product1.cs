namespace Test.CodeMaze.FactoryMethodPractice
{
    public class Product1 : ICommon
    {
        public void Operate()
        {
            Console.WriteLine("Do some thing special");
        }

        public string Title { get; set; }
    }
}
