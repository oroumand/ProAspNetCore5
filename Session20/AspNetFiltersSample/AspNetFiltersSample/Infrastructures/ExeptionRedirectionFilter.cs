using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetFiltersSample.Infrastructures
{
    public class ExeptionRedirectionFilter:ExceptionFilterAttribute
    {
        private readonly IExeptionLogger exeptionLogger;

        public ExeptionRedirectionFilter(IExeptionLogger exeptionLogger)
        {
            this.exeptionLogger = exeptionLogger;
        }
        public override void OnException(ExceptionContext context)
        {
            var dict = new Dictionary<string, string>();
            dict["Message"] = "پردازش ناموفق بود با کد رهگیری ارسال شده خطا را پیگیری کنید";
            //Log Exception


            dict["LogId"] = exeptionLogger.Log(context.Exception).ToString();

            dict["ExeptionMessage"] = context.Exception.Message;

            context.Result = new ViewResult
            {
                ViewName = "Exeption",
                ViewData = new ViewDataDictionary(
                new EmptyModelMetadataProvider(),
                new ModelStateDictionary())
                { Model = dict }
            };

        }
    }
}
