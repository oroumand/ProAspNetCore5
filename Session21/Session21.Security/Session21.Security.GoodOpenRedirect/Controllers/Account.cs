using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Session21.Security.GoodOpenRedirect.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace Session21.Security.GoodOpenRedirect.Controllers
{
    public class LoginModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ReturnUrl{ get; set; }
    }
    public class AccountController : Controller
    {
        public IActionResult Login(string returnUrl="/")
        {
            return View(new LoginModel
            {
                ReturnUrl = returnUrl
            });
        }
        [HttpPost]
        public IActionResult Login(LoginModel loginModel)
        {
            //Login User

            return LocalRedirect(loginModel.ReturnUrl);
        }
    }
}
