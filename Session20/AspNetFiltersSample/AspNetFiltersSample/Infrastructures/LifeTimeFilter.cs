using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetFiltersSample.Infrastructures
{
    public class MyOrderFilter:ActionFilterAttribute
    {
        public string Message { get; set; }
        public MyOrderFilter(string message)
        {
            Message = message;
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine($"Action Executing {Message}");
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine($"Action Executed {Message}");
        }
    }
    public class LifeTimeFilter:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
          
        }
    }
}
