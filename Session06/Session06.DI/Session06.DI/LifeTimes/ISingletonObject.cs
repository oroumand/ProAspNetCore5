using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session06.DI.LifeTimes
{
    public interface ISingletonObject
    {
        string GetId();
    }
    public class SingletonObject : ISingletonObject
    {
        private string _id;
        public SingletonObject()
        {
            _id = Guid.NewGuid().ToString();
        }
        public string GetId()
        {
            return _id;
        }
    }

    public class SingletonTestMiddleware
    {
        private readonly RequestDelegate _next;

        public SingletonTestMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext, ISingletonObject singletonObject01, ISingletonObject singletonObject02)
        {

            await httpContext.Response.WriteAsync($"singletoneObject01: " +
                $"{singletonObject01.GetId()}, singletonObject02: {singletonObject02.GetId()}\n\n");
            await _next(httpContext);
        }
    }
}
