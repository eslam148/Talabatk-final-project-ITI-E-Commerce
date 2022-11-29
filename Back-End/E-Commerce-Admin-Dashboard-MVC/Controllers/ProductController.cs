using E_Commerce_Admin_Dashboard_MVC;
using E_Commerce_Admin_Dashboard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace E_Commerce_Admin_Dashboard_MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductServices services;
        private readonly ISubcategory subcategory;
        public ProductController(IProductServices services, ISubcategory subcategory)
        {
            this.services = services;
            this.subcategory = subcategory;
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
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var prod = services.GetProductById(Id);
            return View(prod);
        }
        public IActionResult ConfirmDelete(int Id)
        {
            services.DeleteProduct(Id);
            return RedirectToAction("GetProductExisting");
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            ViewBag.Category = subcategory.Get();//.Select(i=>new SelectListItem(i.BrandName,i.Id.ToString()));
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(ProductsVM product)
        {
            if (ModelState.IsValid == false)
            {
                var errors =
                    ModelState.SelectMany(i => i.Value.Errors.Select(x => x.ErrorMessage));

                foreach (string err in errors)
                {
                    ModelState.AddModelError("", err);
                }
                ViewBag.Category = subcategory.Get();
                return View();
            }
            else {
                services.AddProdcut(product);
                return RedirectToAction("GetProductExisting");
            }
            
        }
    }
}
