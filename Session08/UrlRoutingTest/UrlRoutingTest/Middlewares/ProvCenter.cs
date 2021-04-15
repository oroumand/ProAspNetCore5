using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
namespace UrlRoutingTest.Middlewares
{
    public class ProvCenter
    {
        private readonly RequestDelegate _next;

        public ProvCenter(RequestDelegate next)
        {
            _next = next;
        }
        public ProvCenter()
        {

        }
        public async Task Invoke(HttpContext httpContext)
        {
            string centername = string.Empty;
            //var pathSegments = httpContext.Request.Path.ToString().Split("/", StringSplitOptions.RemoveEmptyEntries);
            //if (pathSegments != null && pathSegments.Length == 2 && pathSegments[0] == "pc")
            //{
            var prov = httpContext.Request.RouteValues["provience"]; //pathSegments[1];
               
                switch (prov)
                {
                    case "Tehran":
                        centername = "Tehran";
                        break;
                    case "Gilan":
                        centername = "Rasht";
                        break;
                    case "Mazandaran":
                        centername = "Sari";
                        break;
                    case "Rasht":
                    //string path = "/cp/Rasht";
                    var linkGenerator = httpContext.RequestServices.GetService<LinkGenerator>();
                    var path = linkGenerator.GetPathByRouteValues(httpContext, "cityPop", new { city = prov });
                    httpContext.Response.Redirect(path);
                        break;
                }

            //}
            if (!string.IsNullOrEmpty(centername))
            {
                await httpContext.Response.WriteAsync($"Center of  {prov} is {centername}");
            }
            else if (_next != null)
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
