using IdentitySamples.Mvc.Models.AAA.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentitySamples.Mvc.Controllers
{

    public class UsersController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UsersController(UserManager<ApplicationUser> userManager,RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public IActionResult Index()
        {
            var users = _userManager.Users.ToList();
            return View(users);
        }
        [Authorize("AdminUsers")]
        public IActionResult Create()
        {
            return View(new CreateUserModel());
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateUserModel model)
        {
            if (ModelState.IsValid)
            {
                var identityUser = new ApplicationUser
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    Ssn = model.SSN
                };
                var result = await _userManager.CreateAsync(identityUser, model.Password);
                if (result.Succeeded)
                {
                    TempData["Message"] = "User Created";
                    return RedirectToAction("Index", "Users");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            var result = await _userManager.DeleteAsync(user);

            if (result.Succeeded)
            {
                TempData["Message"] = "User Removed";
            }
            else
            {
                TempData["Message"] = "Action failed";
            }
            return RedirectToAction("Index", "Users");
        }

        public async Task<IActionResult> EditUserRoles(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            var userRoles = await _userManager.GetRolesAsync(user);
            var roles = _roleManager.Roles.ToList();

            var model = new EditUserRolesViewModel
            {
                UserName = user.UserName,
                UserId = user.Id,
                Roles = roles,
                UserRoles = userRoles.ToList()
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> EditUserRoles(string userId, List<string> roles)
        {
            var user = await _userManager.FindByIdAsync(userId);
            var curentRole = await _userManager.GetRolesAsync(user);

            foreach (var role in curentRole)
            {
                if(!roles.Any(c=>c == role))
                {
                    var removeRoleResult = await  _userManager.RemoveFromRoleAsync(user,role);
                }
            }

            foreach (var role in roles)
            {
                var isInRole = await _userManager.IsInRoleAsync(user, role);
                if (!isInRole)
                {
                    var addToRoleResult = await _userManager.AddToRoleAsync(user, role);
                }
            }

            return RedirectToAction("Index", "Users");
        }
    }
}
