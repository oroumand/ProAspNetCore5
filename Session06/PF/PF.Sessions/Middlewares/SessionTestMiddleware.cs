using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PF.Sessions.Middlewares
{
    public class SessionTestMiddleware
    {
        private readonly RequestDelegate _next;

        public SessionTestMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext httpContext)
        {
            var counter = httpContext.Session.GetInt32("Counter01") ?? 0;
            counter++;
            httpContext.Session.SetInt32("Counter01", counter);
            await httpContext.Session.CommitAsync();
            await httpContext.Response.WriteAsync($"The value of Counter01 is : {counter} \n\n");

            await _next(httpContext);
        }
    }
}
