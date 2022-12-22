using E_Commerce_Admin_Dashboard_MVC.Models;
using E_CommerceDB;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Net.Mail;
using System.Net;
using Microsoft.AspNetCore.SignalR;

namespace E_Commerce_Admin_Dashboard_MVC.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdmin IAdmin;
        RoleManager<IdentityRole> RoleManager;
        UserManager<User> UserManager;
        SignInManager<User> SignInManager;
        [ViewData]
        public String UserImage { get; set; }
        public AdminController(
            IAdmin _IAdmin
            ,RoleManager<IdentityRole> roleManager
            ,UserManager<User> _UserManager
            ,SignInManager<User> _SignInManager
           )
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
        public IActionResult SignUp(string ReturnUrl = null)
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
                    UserName = admin.UserName,
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
                   // await UserManager.AddToRoleAsync(user, admin.Role);
                    await UserManager.AddToRoleAsync(user, "Admin");

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
        public async Task<IActionResult> LogIn(LogInModel logInModel)
        {
            if (ModelState.IsValid == false)
                return View();
            else
            {
                var result
                     = await SignInManager.PasswordSignInAsync
                        (logInModel.UserName, logInModel.Password, logInModel.RememberMe,
                             true);
                if (result.IsNotAllowed == true)
                {
                    ModelState.AddModelError("", "Invalid User Name Of Password");
                    return View();
                }
                else if (result.IsLockedOut)
                {
                    ModelState.AddModelError("", "You're Locked Out Please Try Again After 1 Minute");
                    return View();
                }
                else
                {
                    if (!string.IsNullOrEmpty(logInModel.ReturnUrl))
                        return LocalRedirect(logInModel.ReturnUrl);
                    else
                        //return RedirectToAction("index");
                        return RedirectToAction("Index", "Home");
                }

            }
        }
        [HttpGet]
        public async Task<String> GetProfileImage()
        {
            var user = await UserManager.GetUserAsync(User);

            return user.ProfilieImage;
        }
        [HttpGet]
        public new async Task<IActionResult> SignOut()
        {
            await SignInManager.SignOutAsync();
            return RedirectToAction("LogIn", "Admin");
        }
    }
}
