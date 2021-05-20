using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Session10.AspNetUnitTesting.Api;
using Session10.AspNetUnitTesting.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Session10.AspNetUnitTesting.ApiTest
{
    public class IntegrationTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _fixture;
        public IntegrationTests(WebApplicationFactory<Startup> fixture)
        {
            _fixture = fixture;
        }
        [Fact]
        public async Task HelloRequest_ReturnsHello()
        {

            var customFactory = _fixture.WithWebHostBuilder(
            (IWebHostBuilder hostBuilder) =>
            {
                hostBuilder.ConfigureTestServices(services =>
                {
                    services.RemoveAll<ICustomeService>();
                    services.AddSingleton<ICustomeService, FakeService>();
                });
            });

            HttpClient client = customFactory.CreateClient();

            var response = await client.GetAsync("/hello");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            Assert.Equal("Hello. How are you?", content);
        }
    }
}
