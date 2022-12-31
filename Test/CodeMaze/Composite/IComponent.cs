namespace Test.CodeMaze.Composite
{
    public interface IComponent
    {
        void Add(Component component);
        void Remove(Component component);
    }
}
