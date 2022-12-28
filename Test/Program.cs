// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
using Test.CodeMaze.Builder;
using Test.HttpClientHelper;


//var serviceprovider = new ServiceCollection()
//    .AddHttpClient("TestClient", config =>
//    {
//        config.BaseAddress = new Uri("");
//        config.DefaultRequestHeaders.Clear();
//      
//    });
//Console.WriteLine("Hello, World!");


Executer executer = new Executer();
executer.ExecuteWithoutHeader();


//CrudService service = new CrudService();
//await service.Execute();