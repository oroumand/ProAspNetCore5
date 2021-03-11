using Microsoft.AspNetCore.Http;
using Session06.DI.ApplicaitonService;
using Session06.DI.DataAccess;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Session06.DI.Middlewares
{
    public class CreatePersonMiddleware
    {
        private readonly RequestDelegate _next;

        public CreatePersonMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext, CreatePersonService createPersonService, IList<string> list, IList<int> intList)
        {

            createPersonService.Create("Farid", "Taheri");
            await _next(httpContext);
        }
    }
}
