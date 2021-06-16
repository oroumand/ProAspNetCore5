using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session15.ModelBindingAndValidation.Controlles
{
    public class HeaderController : Controller
    {
        public IActionResult Index([FromHeader] string Accept)
        {

            return View("Index",Accept);
        }
    }
}
