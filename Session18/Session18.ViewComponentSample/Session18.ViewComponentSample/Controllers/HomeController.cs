using Microsoft.AspNetCore.Mvc;
using Session18.ViewComponentSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session18.ViewComponentSample.Controllers
{
    [ViewComponent(Name ="Temp")]
    public class HomeController : Controller
    {
        private readonly IPersonRepository personRepository;

        public HomeController(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }
        public IActionResult Index()
        {
            var result = personRepository.GetPeople();
            return View(result);
        }

        public string Invoke()
        {
            return "Test";
        }
    }
}
