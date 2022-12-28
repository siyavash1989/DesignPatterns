// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
using Test.CodeMaze.Builder;
using Test.CodeMaze.BuilderRecursive;
using Test.CodeMaze.BuilderRecursiveGeneric;
using Test.CodeMaze.PracticeBuilder;
using Test.HttpClientHelper;


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
var exe = new GenericExecuter();
exe.Execute();

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