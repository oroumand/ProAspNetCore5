using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetFiltersSample.Infrastructures
{
    public class ActionMethodExecutionTimeFilter:ActionFilterAttribute
    {
        private Stopwatch stopwatch;
        public ActionMethodExecutionTimeFilter()
        {
            stopwatch = new Stopwatch();
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            stopwatch.Start();
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            stopwatch.Stop();
            var time = stopwatch.ElapsedMilliseconds;
            Console.WriteLine($"Total Execution time is: {time}");
        }

        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            stopwatch.Restart();
            stopwatch.Start();

            await next();
            stopwatch.Stop();
            var time = stopwatch.ElapsedMilliseconds;
            Console.WriteLine($"Total Execution time is: {time}");

        }
    }
}
