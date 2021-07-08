using Microsoft.AspNetCore.Mvc;
using Session18.TaghelpersSample.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session18.TaghelpersSample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new Person
            {
                FirstName = "Alireza",
                LastName = "Oroumand",
                Age = 148
            });
        }

        [HttpPost]
        public IActionResult Index(Person person)
        {
            var p = person;
            return RedirectToAction("Index");
        }
    }
}
