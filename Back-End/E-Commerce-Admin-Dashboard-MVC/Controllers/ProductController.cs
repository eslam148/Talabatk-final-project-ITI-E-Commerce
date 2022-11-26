using E_Commerce_Admin_Dashboard_MVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_Admin_Dashboard_MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductServices services;
        public ProductController(IProductServices services)
        {
            this.services = services;
        }
        [HttpGet]
        public IActionResult GetProductExisting()
        {
            var result = services.GetAllExisting();
            return View(result);
        }
        [HttpGet]
        public IActionResult GetProductSelled()
        {

            var result = services.GetAllSold();
            return View(result);
        }
    }
}
