using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace AspNetFiltersSample.Infrastructures
{
    public class IsHttpsFilterAttribute : Attribute,IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if(!context.HttpContext.Request.IsHttps)
            {
                context.Result = new StatusCodeResult(401);
            }
        }
    }
}
