using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session06.DI.LifeTimes
{
    public interface ITransientObject
    {
        string GetId();
    }
    public class TransientObject : ITransientObject
    {
        private string _id;
        public TransientObject()
        {
            _id = Guid.NewGuid().ToString();
        }
        public string GetId()
        {
            return _id;
        }
    }

    public class TransientTestMiddleware
    {
        private readonly RequestDelegate _next;

        public TransientTestMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext, ITransientObject transientObject01, ITransientObject transientObject02)
        {

            await httpContext.Response.WriteAsync($"transientObject01: " +
                $"{transientObject01.GetId()}, transientObject02: {transientObject02.GetId()}\n\n");
            await _next(httpContext);
        }
    }
}
