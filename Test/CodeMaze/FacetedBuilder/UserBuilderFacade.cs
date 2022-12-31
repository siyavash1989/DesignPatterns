namespace Test.CodeMaze.FacetedBuilder
{
    public class UserBuilderFacade
    {
        protected User User { get; set; }
        public UserBuilderFacade()
        {
            User = new User();
        }

        public User Build() => User;

        public UserInfoBuilder Info => new UserInfoBuilder(User);
        public UserAddressBuilder Address => new UserAddressBuilder(User);
    }
}
