using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session06.DI.LifeTimes
{
    public interface IScopeObject
    {
        string GetId();
    }
    public class ScopeObject : IScopeObject
    {
        private string _id;
        public ScopeObject()
        {
            _id = Guid.NewGuid().ToString();
        }
        public string GetId()
        {
            return _id;
        }
    }

    public class ScopeTestMiddleware
    {
        private readonly RequestDelegate _next;

        public ScopeTestMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext, IScopeObject scopeObject01, IScopeObject scopeObject02)
        {

            await httpContext.Response.WriteAsync($"scopeObject02: " +
                $"{scopeObject01.GetId()}, scopeObject02: {scopeObject02.GetId()}\n\n");
            await _next(httpContext);
        }
    }
}
