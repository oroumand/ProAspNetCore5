using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Platform.Middlewares
{
    public class LoggerMiddleware// : IMiddleware
    {
        private readonly RequestDelegate _next;

        public LoggerMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            await _next(context);
            stopwatch.Stop();
            Console.WriteLine("".PadRight(100, '-'));
            Console.WriteLine($"Total time {stopwatch.ElapsedMilliseconds}");
            Console.WriteLine("".PadRight(100, '-'));
        }
    }
}
