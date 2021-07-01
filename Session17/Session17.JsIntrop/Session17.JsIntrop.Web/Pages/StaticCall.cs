using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session17.JsIntrop.Web.Pages
{
    public static class StaticCall
    {
        [JSInvokable]
        public static void LogStatic()
        {
            Console.WriteLine("Log from static class");
        }
    }

    public class InstanceCall
    {
        [JSInvokable]
        public  void LogInstance()
        {
            Console.WriteLine("Log from Instance class");
        }
    }
}
