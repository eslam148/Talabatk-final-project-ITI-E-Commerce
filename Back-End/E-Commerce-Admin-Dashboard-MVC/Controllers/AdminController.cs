using E_Commerce_Admin_Dashboard_MVC.Models;
using E_CommerceDB;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Net.Mail;
using System.Net;

namespace E_Commerce_Admin_Dashboard_MVC.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdmin IAdmin;
        RoleManager<IdentityRole> RoleManager;
        UserManager<User> UserManager;
        SignInManager<User> SignInManager;
        public AdminController(
            IAdmin _IAdmin
            ,RoleManager<IdentityRole> roleManager
            ,UserManager<User> _UserManager
            ,SignInManager<User> _SignInManager)
        {
            IAdmin = _IAdmin;
            UserManager = _UserManager;
            SignInManager = _SignInManager;
            RoleManager=roleManager;
        }
        [HttpGet]

        public IActionResult AddRole()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddRole(RoleCreateModel Role)
        {
            if (ModelState.IsValid == false)
                return View();
            else
            {
                var result =
                await RoleManager.CreateAsync(
                    new IdentityRole
                    {
                        Name=Role.Name
                    });
                if (result.Succeeded == false)
                {
                    result.Errors.ToList().ForEach(i =>
                    {
                        ModelState.AddModelError("", i.Description);
                    });
                    return View();
                }
                else
                {
                    return View();
                }
            }
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            ViewBag.Roles = RoleManager.Roles
               .Select(i => new SelectListItem(i.Name, i.Name));
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(AdminRegistrationModel admin)
        {
            if (ModelState.IsValid == false)
                return View();
            else
            {
                User user = new User()
                {
                    First_Name = admin.FirstName,
                    Last_Name = admin.LastName,
                    Email = admin.Email,
                    PhoneNumber = admin.PhoneNumber
                   
                };
                IdentityResult result = await UserManager.CreateAsync(user, admin.Password);
                if (result.Succeeded == false)
                {
                    result.Errors.ToList().ForEach(i => { ModelState.AddModelError("", i.Description); });
                    return View();
                }
                else
                {
                    await UserManager.AddToRoleAsync(user, admin.Role);
                    return RedirectToAction("LogIn");

                    
                }
            }
        }
        [HttpGet]
        public IActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LogIn(LogInModel logInModel)
        {
            return View();
        }
    }
}
