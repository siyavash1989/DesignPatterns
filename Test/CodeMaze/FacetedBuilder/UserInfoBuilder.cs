namespace Test.CodeMaze.FacetedBuilder
{
    public class UserInfoBuilder:UserBuilderFacade
    {
        public UserInfoBuilder(User user)
        {
            User = user;
        }

        public UserInfoBuilder WithName(string name)
        {
            User.Name = name;
            return this;
        }

        public UserInfoBuilder WithFamily(string family)
        {
            User.Family = family;
            return this;
        }

        public UserInfoBuilder WithAge(int age)
        {
            User.Age = age;
            return this;
        }

    }
}
