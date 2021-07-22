using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetFiltersSample.Infrastructures
{
    public class ResultExectionTimerFilter:ResultFilterAttribute
    {
        private Stopwatch stopwatch;
        public ResultExectionTimerFilter()
        {
            stopwatch = new Stopwatch();
        }
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            stopwatch.Start();
        }

        public override void OnResultExecuted(ResultExecutedContext context)
        {
            stopwatch.Stop();
            var time = stopwatch.ElapsedMilliseconds;

            Console.WriteLine($"Result time is {time}");
        }
    }
}
