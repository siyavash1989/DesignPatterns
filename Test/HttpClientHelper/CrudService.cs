using Microsoft.AspNetCore.JsonPatch;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Test.HttpClientHelper
{
    public class CrudService
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private readonly CancellationTokenSource cancellationTokenSource;
        private readonly IHttpClientFactory _httpClientFactory;

        public CrudService(IHttpClientFactory httpClientFactory)
        {
            _httpClient.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");
            _httpClient.Timeout = new TimeSpan(0, 0, 30);//TimeSpan.FromSeconds(10);
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json", 0.1));
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("text/xml"));

            cancellationTokenSource = new CancellationTokenSource();
            _httpClientFactory = httpClientFactory;
        }

        public async Task Execute()
        {
            cancellationTokenSource.CancelAfter(2000);
            await GetWithCancel(cancellationTokenSource.Token);
        }

        public async Task GetCompanies()
        {
            var response = await _httpClient.GetAsync("todos");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                if (response.Content.Headers.ContentType.MediaType == "application/json")
                {
                    var respObject = JsonConvert.DeserializeObject<List<Company>>(content);
                }
                else if (response.Content.Headers.ContentType.MediaType == "text/xml")
                {
                    var doc = XDocument.Parse(content);
                    foreach (var item in doc.Descendants())
                    {
                        item.Attributes().Where(a => a.IsNamespaceDeclaration).Remove();
                        item.Name = item.Name.LocalName;
                    }

                    var serializer = new XmlSerializer(typeof(List<Company>));
                    var respObject = (List<Company>)serializer.Deserialize(new StringReader(doc.ToString()));
                }
            }
        }

        public async Task GetCompaniesWithXML()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "todos");
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("text/xml"));

            var response = await _httpClient.SendAsync(request);
            var content = await response.Content.ReadAsStringAsync();

            var doc = XDocument.Parse(content);
            foreach (var item in doc.Descendants())
            {
                item.Attributes().Where(a => a.IsNamespaceDeclaration).Remove();
                item.Name = item.Name.LocalName;
            }

            var serializer = new XmlSerializer(typeof(List<Company>));
            var respObject = (List<Company>)serializer.Deserialize(new StringReader(doc.ToString()));
        }

        public async Task CreateCompany()
        {
            var company = new Company()
            {
                Completed = true,
                Id = 103,
                Title = "test comp",
                UserId = 112
            };

            var stringCompany = JsonConvert.SerializeObject(company);
            var requestContent = new StringContent(stringCompany, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("todos", requestContent);
            var content = await response.Content.ReadAsStringAsync();

            var output = JsonConvert.DeserializeObject<Company>(content);

        }

        public async Task CreateCompanyWithRequest()
        {
            var company = new Company()
            {
                Completed = true,
                Id = 103,
                Title = "test comp",
                UserId = 112
            };

            var stringCompany = JsonConvert.SerializeObject(company);
            var requestContent = new StringContent(stringCompany, Encoding.UTF8, "application/json");

            var request = new HttpRequestMessage(HttpMethod.Post, "todos");
            request.Content = requestContent;

            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = await _httpClient.SendAsync(request);

            //other parts

        }

        public async Task PartialUpdate()
        {
            var patchDoc = new JsonPatchDocument<Company>();
            patchDoc.Replace(e => e.Title, "new title");
            patchDoc.Remove(e => e.Completed);

            var stringRequest = JsonConvert.SerializeObject(patchDoc);
            var requestContent = new StringContent(stringRequest, Encoding.UTF8, "application/json-patch+json");

            var response = await _httpClient.PatchAsync("todos", requestContent);
            //other parts
        }

        public async Task GetWithStream()
        {
            using (var response = await _httpClient.GetAsync("todos",HttpCompletionOption.ResponseHeadersRead))
            {
                var stream = await response.Content.ReadAsStreamAsync();
                var respObject = await System.Text.Json.JsonSerializer.DeserializeAsync<List<Company>>(stream);

            }
        }

        public async Task GetWithCancel(CancellationToken cancellationToken)
        {
            try
            {
                using (var response = await _httpClient.GetAsync("todos", HttpCompletionOption.ResponseHeadersRead, cancellationToken))
                {
                    var stream = await response.Content.ReadAsStreamAsync();
                    var respObject = await System.Text.Json.JsonSerializer.DeserializeAsync<List<Company>>(stream);

                }
            }
            catch (OperationCanceledException ex)
            {
                Console.WriteLine(ex.Message);                
            }
            
        }

        public async Task CreateCompanyWithStream()
        {
            var company = new Company()
            {
                Completed = true,
                Id = 103,
                Title = "test comp",
                UserId = 112
            };

            var ms = new MemoryStream();

            await System.Text.Json.JsonSerializer.SerializeAsync(ms, company);
            ms.Seek(0, SeekOrigin.Begin);

            var request = new HttpRequestMessage(HttpMethod.Post, "todos");
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            

            using (var requestContent = new StreamContent(ms))
            {
                request.Content = requestContent;
                request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead))
                {
                    var content = await response.Content.ReadAsStreamAsync();
                    var respObject = await System.Text.Json.JsonSerializer.DeserializeAsync<List<Company>>(content);
                }
                
            }
        }
    }




    public class Company
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Completed { get; set; }
    }
}
