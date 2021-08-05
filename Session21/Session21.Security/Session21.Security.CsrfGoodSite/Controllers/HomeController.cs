using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Session21.Security.CsrfGoodSite.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Session21.Security.CsrfGoodSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICustomerRepository customerRepository;

        public HomeController(ILogger<HomeController> logger,ICustomerRepository customerRepository)
        {
            _logger = logger;
            this.customerRepository = customerRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(int customerId)
        {
            Response.Cookies.Append("CustomerId", customerId.ToString(),new Microsoft.AspNetCore.Http.CookieOptions
            {
                SameSite= Microsoft.AspNetCore.Http.SameSiteMode.Strict
            });
            return RedirectToAction("ViewEmtiaz");
        }

        public IActionResult ViewEmtiaz()
        {
            var customerId = int.Parse(Request.Cookies["CustomerId"]);
            var customer = customerRepository.GetCustomer(customerId);
            return View(customer);
            
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Transfer(int destination)
        {
            var customerId = int.Parse(Request.Cookies["CustomerId"]);
            var customer = customerRepository.GetCustomer(customerId);
            var destinationCustomer = customerRepository.GetCustomer(destination);
            var newEmtial = destinationCustomer.Emtiaz + customer.Emtiaz;
            customerRepository.SetEmtiaz(customerId, 0);
            customerRepository.SetEmtiaz(destination, newEmtial);
            return RedirectToAction("ViewEmtiaz");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
