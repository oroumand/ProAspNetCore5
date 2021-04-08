using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Logging.Test01.Middlewares
{
    public class RequestTrackPerformanceLoggerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<RequestTrackPerformanceLoggerMiddleware> _logger;

        public RequestTrackPerformanceLoggerMiddleware(RequestDelegate next, ILogger<RequestTrackPerformanceLoggerMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }
        public async Task Invoke(HttpContext httpContext)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            DateTime startDateTime = DateTime.Now;
            Dictionary<string, string> requestScope = new Dictionary<string, string>();
            requestScope["RequestId"] = Guid.NewGuid().ToString();
            requestScope["UserId"] = "1";
            using var scope = _logger.BeginScope(requestScope);

            await _next(httpContext);

            stopwatch.Stop();
            var secconds = stopwatch.ElapsedMilliseconds / 1000.0;
            DateTime endDateTime = DateTime.Now;
            _logger.LogInformation("Request for Path: {Path} started at {StartDateTime}" +
                " and finished at {endDateTime}. it takes {secconds} secconds", httpContext.Request.Path, startDateTime, endDateTime, secconds);

        }
    }
}
