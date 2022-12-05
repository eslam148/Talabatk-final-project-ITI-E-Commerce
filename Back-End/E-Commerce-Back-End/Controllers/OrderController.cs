using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_Back_End.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
