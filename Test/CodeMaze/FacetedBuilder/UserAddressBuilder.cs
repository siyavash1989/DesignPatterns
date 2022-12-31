namespace Test.CodeMaze.FacetedBuilder
{
    public class UserAddressBuilder : UserBuilderFacade
    {
        public UserAddressBuilder(User user)
        {
            User = user;
        }

        public UserAddressBuilder WithProvince(string province)
        {
            User.Province = province;
            return this;
        }

        public UserAddressBuilder WithCity(string city)
        {
            User.City = city;
            return this;
        }
    }
}
