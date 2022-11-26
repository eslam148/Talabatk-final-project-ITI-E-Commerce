using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_Admin_Dashboard_MVC.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetBuyers()
        {
            return View();
        }
        public IActionResult GetSellers()
        {
            return View();
        }
    }
}
