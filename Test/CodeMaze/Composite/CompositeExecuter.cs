namespace Test.CodeMaze.Composite
{
    public class CompositeExecuter
    {
        public void Execute()
        {
            var child = new Leaf("title", 10);
            var parent = new Composite("parent", 12);
            parent.Add(child);

            var superParent = new Composite("grandPa", 10.5);
            superParent.Add(parent);
        }
    }
}
