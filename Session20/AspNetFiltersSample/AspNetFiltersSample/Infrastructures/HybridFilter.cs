using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetFiltersSample.Infrastructures
{
    public class HybridFilter : ActionFilterAttribute
    {
        private Stopwatch stopwatch;
        public HybridFilter()
        {
            stopwatch = new Stopwatch();
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            stopwatch.Start();
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            var time = stopwatch.ElapsedMilliseconds;
            Console.WriteLine($"Action Execution time is:{time}");
        }

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            stopwatch.Restart();
        }
        public override void OnResultExecuted(ResultExecutedContext context)
        {
            var time = stopwatch.ElapsedMilliseconds;
            Console.WriteLine($"Result Execution time is:{time}");
        }
    }
}
