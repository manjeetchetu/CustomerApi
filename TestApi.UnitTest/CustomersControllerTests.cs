using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using Shouldly;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using TestApi.Models;
using Xunit;

namespace TestApi.UnitTest
{
    public class CustomersControllerTests : IClassFixture<WebApplicationFactory<TestApi.Startup>>
    {
        private HttpClient _client { get; }
        public CustomersControllerTests(WebApplicationFactory<TestApi.Startup> fixture)
        {
            _client = fixture.CreateClient();
        }
        [Fact]
        public async Task Get_Should_Retrieve_Customers()
        {
            var response = await _client.GetAsync("/api/Customers");
            response.StatusCode.ShouldBe(HttpStatusCode.OK);
        }


    }
}
