using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Session10.AspNetUnitTesting.Api;
using Session10.AspNetUnitTesting.Api.Models;

namespace Session10.AspNetUnitTesting.ApiTest
{
    public class CustomWebApplicationFactory : WebApplicationFactory<Startup>
    {
        protected override void ConfigureWebHost(
        IWebHostBuilder hostBuilder)
        {
            hostBuilder.ConfigureTestServices(services =>
            {
                services.RemoveAll<ICustomeService>();
                services.AddSingleton<ICustomeService, FakeService>();
            });
        }
    }
}
