using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PF.Cookies.Middlwares
{
    public class CookieMiddleware
    {
        private readonly RequestDelegate _next;

        public CookieMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            int counter1 = int.Parse(context.Request.Cookies["counter1"] ?? "0") + 1;
            context.Response.Cookies.Append("counter1", counter1.ToString(),
            new CookieOptions
            {
                IsEssential = true,
                MaxAge = TimeSpan.FromMinutes(30)

            });
            await context.Response.WriteAsync($"counter1 {counter1} \n\n");


            int counter2 = int.Parse(context.Request.Cookies["counter2"] ?? "0") + 1;
            context.Response.Cookies.Append("counter2", counter2.ToString(),
            new CookieOptions
            {
                IsEssential = false,
                MaxAge = TimeSpan.FromMinutes(30)

            });
            await context.Response.WriteAsync($"counter2 {counter2} \n\n");
            await _next(context);
        }
    }
}
