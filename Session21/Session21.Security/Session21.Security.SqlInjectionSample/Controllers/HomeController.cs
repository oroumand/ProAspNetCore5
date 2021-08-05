using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Session21.Security.SqlInjectionSample.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Session21.Security.SqlInjectionSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string searchTerm = "Taheri")
        {
            var searchTest = $"Select Id,LastName from Customers where LastName = N'{searchTerm}'";
            var sqlConnection = new SqlConnection("Server=.,1533;Database=Identity; User Id =sa; Password=1qaz!QAZ");
            sqlConnection.Open();

            SqlCommand command = new SqlCommand(searchTest, sqlConnection);

            var reader = command.ExecuteReader();
            return View(reader);
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
