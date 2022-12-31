namespace Test.CodeMaze.FacetedBuilder
{
    public class FacadeExecuter
    {
        public void Execute()
        {
            var user = new UserBuilderFacade()
                .Info
                .WithName("mohammad")
                .WithFamily("Shafiei")
                .WithAge(33)
                .Address
                .WithProvince("Tehran")
                .WithCity("Arak")
                .Build();

            Console.WriteLine(user);
        }
    }
}
