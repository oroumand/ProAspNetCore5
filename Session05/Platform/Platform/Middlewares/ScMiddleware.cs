using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Platform.Middlewares
{
    public class ScMiddleware
    {
        private readonly RequestDelegate _next;

        public ScMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext httpContext)
        {
            if (httpContext.Request.Query.ContainsKey("a") && httpContext.Request.Query["a"] == "1")
            {
                await _next(httpContext);
            }
            else
            {
                await httpContext.Response.WriteAsync("You can not use this application");
            }
        }
    }

    public class TerminatorMiddleware
    {
        private readonly RequestDelegate _next;

        public TerminatorMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext httpContext)
        {
            await httpContext.Response.WriteAsync("This is Terminator");
        }
    }

    public interface IDep
    {

    }
    public class MrShoabi 
    {
        private readonly IDep _dep;

        public MrShoabi(IDep dep)
        {
            _dep = dep;
        }
        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            throw new NotImplementedException();
        }
    }
}
