namespace Test.Other.Record
{
    //implicit usage
    public record Person
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public record NewPerson
    {
        //init-only properties
        public string FirstName { get; init; }
        public string LastName { get; init; }
    }

    //Positional Records
    public record class AsianPerson(string FirstName, string LastName)
    {
    }

    public record APerson
    {
        public APerson(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }


    //explicit usage
    public record class PersonClass
    {

    }

    public record struct PersonStruct
    {

    }


    //class
    public class Animal
    {
        public Animal(string category, int age)
        {
            Category = category;
            Age = age;
        }
        public string Category { get; set; }
        public int Age { get; set; }
    }
}
