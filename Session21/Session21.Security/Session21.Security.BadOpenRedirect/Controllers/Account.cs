using Microsoft.AspNetCore.Mvc;


namespace Session21.Security.BadOpenRedirect.Controllers
{
    public class LoginModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }
    public class AccountController : Controller
    {
        public IActionResult Login(string returnUrl = "/")
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

            return Redirect("https://localhost:44394/");
        }
    }
}
