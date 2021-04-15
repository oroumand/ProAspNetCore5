using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace UrlRoutingTest.Middlewares
{
    public class CityPopulation
    {
        private readonly RequestDelegate _next;

        public CityPopulation(RequestDelegate next)
        {
            _next = next;
        }
        public CityPopulation()
        {

        }

        public async Task Invoke(HttpContext httpContext)
        {
            //var pathSegments = httpContext.Request.Path.ToString().Split("/", StringSplitOptions.RemoveEmptyEntries);
            int count = 0;
            //if (pathSegments != null && pathSegments.Length == 2 && pathSegments[0] == "cp")
            //{
                var city = httpContext.Request.RouteValues["city"]; //pathSegments[1];
               
                switch (city)
                {
                    case "Tehran":
                        count = 10_000_000;
                        break;
                    case "Rasht":
                        count = 2_000_000;
                        break;
                    case "Sari":
                        count = 500_000;
                        break;
                }

            //}
            if (count > 0)
            {
                await httpContext.Response.WriteAsync($"Population of  {city} is {count}");
            }
            else if(_next != null)
            {
            await _next(httpContext);
            }
            else
            {
                await httpContext.Response.WriteAsync($"Page Not Found");
                httpContext.Response.StatusCode = 404;
            }
        }
    }
}
