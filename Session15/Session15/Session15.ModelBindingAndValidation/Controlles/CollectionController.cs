using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session15.ModelBindingAndValidation.Controlles
{
    public class CollectionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List(List<string> data)
        {
            return RedirectToAction("Index");
        }

        public IActionResult OrderdList(List<string> data)
        {
            return RedirectToAction("Index");
        }


        public IActionResult Dict(Dictionary<string,string> data)
        {
            return RedirectToAction("Index");
        }
    }
}
