namespace Test.CodeMaze.BuilderGeneric
{
    public class Executer
    {
        public void Execute()
        {
            var emp = EmployeeBuilderDirector
            .NewEmployee
            .SetName("Maks")
            .AtPosition("Software Developer")
            .WithSalary(3500)
            .Build();
            Console.WriteLine(emp);
        }
    }
}
