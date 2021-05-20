using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Hosting;
using Session10.AspNetUnitTesting.Api.Middlewares;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Session10.AspNetUnitTesting.ApiTest
{
    public class HelloMiddlewareTest
    {
        [Fact]
        public async Task Hello_Middleware_CallNext_When_AddressIsInvalid()
        {
            //Arrang
            var httpContext = new DefaultHttpContext();
            httpContext.Request.Path = "/invalidAddress";
            bool runThisMilleware = false;
            RequestDelegate next = (HttpContext context) =>
            {
                runThisMilleware = true;
                return Task.CompletedTask;
            };
            var middleware = new HelloMiddleware(next);

            //Act
            await middleware.Invoke(httpContext);

            //Assert
            Assert.True(runThisMilleware);
        }


        [Fact]
        public async Task Hello_Middleware_SayHello_When_AddressIsHello()
        {
            //Arrang
            var bodyStream = new MemoryStream();
            var context = new DefaultHttpContext();
            context.Response.Body = bodyStream;
            context.Request.Path = "/hello";
            RequestDelegate next = (ctx) => Task.CompletedTask;
            var middleware = new HelloMiddleware(next: next);
            //Act
            await middleware.Invoke(context);

            //Assert
            string response;
            bodyStream.Seek(0, SeekOrigin.Begin);
            using (var stringReader = new StreamReader(bodyStream))
            {
                response = await stringReader.ReadToEndAsync();
            }
            Assert.Equal("Hello. How are you?", response);
            Assert.Equal("text/plain", context.Response.ContentType);
            Assert.Equal(200, context.Response.StatusCode);
        }


        [Fact]
        public async Task Hello_Middleware_SayHello_When_AddressIsHello_Integration()
        {
            var hostBuilder = new HostBuilder()
            .ConfigureWebHost(webHost =>
            {
                webHost.Configure(app =>
                    app.UseMiddleware<HelloMiddleware>());
                webHost.UseTestServer();
            });
            IHost host = await hostBuilder.StartAsync();
            HttpClient client = host.GetTestClient();
            var response = await client.GetAsync("/hello");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            Assert.Equal("Hello. How are you?", content);
        }
    }
}
