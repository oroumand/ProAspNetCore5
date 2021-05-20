using Microsoft.AspNetCore.Mvc.Testing;
using Session10.AspNetUnitTesting.Api;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Session10.AspNetUnitTesting.ApiTest
{
    public class EndToEndTests: IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _fixture;
        public EndToEndTests(WebApplicationFactory<Startup> fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public async Task HelloRequest_ReturnsHello()
        {
            HttpClient client = _fixture.CreateClient();
            var response = await client.GetAsync("/hello");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            Assert.Equal("Hello. How are you?", content);
        }
    }
}
