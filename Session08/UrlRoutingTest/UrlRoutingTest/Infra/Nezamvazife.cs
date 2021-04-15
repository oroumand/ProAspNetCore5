using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UrlRoutingTest.Infra
{
    public class Nezamvazife : IRouteConstraint
    {
        public bool Match(HttpContext httpContext, 
            IRouter route, string routeKey, 
            RouteValueDictionary values, RouteDirection routeDirection)
        {
            var vaziat = values[routeKey].ToString();
            if(vaziat == "rafte" || vaziat == "narafte")
            {
                return true;
            }
            return false;
        }
    }
}
