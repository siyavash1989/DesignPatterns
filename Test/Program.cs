// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
using Test.CodeMaze.Builder;
using Test.CodeMaze.BuilderRecursive;
using Test.CodeMaze.BuilderRecursiveGeneric;
using Test.CodeMaze.Command;
using Test.CodeMaze.Composite;
using Test.CodeMaze.Facade;
using Test.CodeMaze.FactoryMethod;
using Test.CodeMaze.FactoryMethodPractice;
using Test.CodeMaze.PracticeBuilder;
using Test.CodeMaze.Strategy;
using Test.HttpClientHelper;
using Test.Other.Concurrency;
using Test.Other.Delegates;
using Test.Other.Record;
using Test.Other.RefOut;


//var serviceprovider = new ServiceCollection()
//    .AddHttpClient("TestClient", config =>
//    {
//        config.BaseAddress = new Uri("");
//        config.DefaultRequestHeaders.Clear();
//      
//    });
//Console.WriteLine("Hello, World!");


//Executer executer = new Executer();
//executer.ExecuteWithoutHeader();


//recursive
//var exe = new FacadeExecuter();
//exe.Execute();

//var products = new List<Test.CodeMaze.PracticeBuilder.Product>
//            {
//                new Test.CodeMaze.PracticeBuilder.Product { Title = "Monitor", Id = 200 },
//                new Test.CodeMaze.PracticeBuilder.Product { Title = "Mouse", Id = 201 },
//                new Test.CodeMaze.PracticeBuilder.Product { Title = "Keyboard", Id = 305}
//            };
//var builder = new StockReportBuilder(products);
//var director = new StockBuilderDirector(builder);
//director.Build();


//var result = builder.Build();
//Console.WriteLine(result);

//CrudService service = new CrudService();
//await service.Execute();


//var person1 = new Person("moh", "Sha");
//var person2 = new Person("moh", "Sha");
//var person3 = new Person("ami", "Sha");

//var person4 = new APerson("moh", "Sha");


//Console.WriteLine($"person1 == person2 ?  {person1 == person2}");
//Console.WriteLine($"person1 == person3 ?  {person1 == person3}");

//Console.WriteLine($"person1 == person4 ?  {Equals(person1,person4)}");


//var animal1 = new Animal("Dog", 12);
//var animal2 = new Animal("Dog", 12);
//var animal3 = animal1;

//Console.WriteLine($"animal1 == animal2 ? {animal1 == animal2}");
//Console.WriteLine($"animal1 == animal3 ? {animal1 == animal3}");


//var person1 = new NewPerson { FirstName = "Moh", LastName = "Sha" };
//var person2 = new NewPerson { FirstName = "Moh", LastName = "Sha" };
//var person3 = new NewPerson { FirstName = "Ami", LastName = "Sha" };

//person1.FirstName = "some thing else";

//var person1 = new AsianPerson("Moh", "Sha");
//person1.FirstName = "";


//cloning with 'with'
//var person2 = person1 with { LastName = "She" };
//var person3 = person1 with { };
//Console.WriteLine($"person1 == person3 ?  {person1 == person3}");



//Sample.RunActionFuncSample();

//var thread = new SampleThread();
//thread.DoSomething();


//var sample = new RefOutTest();
//sample.Executer();



Console.ReadKey();