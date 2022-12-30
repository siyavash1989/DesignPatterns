namespace Test.CodeMaze.FactoryMethodPractice
{
    public class PracticeFMExecuter
    {
        public void Execute()
        {
            var newInstance = new Common().CreateInstance(Actions.Product1);


        }
    }
}
