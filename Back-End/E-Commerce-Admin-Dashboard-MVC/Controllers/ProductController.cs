using E_Commerce_Admin_Dashboard_MVC;
using E_Commerce_Admin_Dashboard_MVC.Models;
using E_CommerceDB;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using X.PagedList;

namespace E_Commerce_Admin_Dashboard_MVC.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ProductController : Controller
    {
        private readonly IProductServices services;
        private readonly ISubcategory subcategory;
        UserManager<User> UserManager;
        public ProductController(IProductServices services, ISubcategory subcategory, UserManager<User> _UserManager)
        {
            this.services = services;
            this.subcategory = subcategory;
            UserManager = _UserManager;
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
        [HttpGet]
        public IActionResult ConfirmDelete(int Id)
        {
            services.DeleteProduct(Id);
            return RedirectToAction("GetProductExisting");
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            ViewBag.Category = subcategory.Get();//.Select(i=>new SelectListItem(i.BrandName,i.Id.ToString()));
            ViewBag.Discount = services.GitALlDiscount();
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
                ViewBag.Discount = services.GitALlDiscount();
                return View();
            }
            else {
                product.Progress=1;
                product.SellerId = "248d7261-521d-46c6-a62e-fec646548071";//UserManager.GetUserId(User);
                services.AddProdcut(product);
                return View(); //RedirectToAction("GetAdminProduct");
            }
          //  return RedirectToAction("GetAdminProduct");
        }

        [HttpGet]
        public IActionResult GetAdminProduct(int pageIndex = 1, int pageSize = 4)
        {
            var result = services.GetAllAdminProduct().ToPagedList(pageIndex, pageSize); 
           // result.ToPagedList(pageIndex, pageSize);
            return View(result);
        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            ViewBag.Category = subcategory.Get();//.Select(i=>new SelectListItem(i.BrandName,i.Id.ToString()));
            ViewBag.Discount = services.GitALlDiscount();
            var prod = services.GetProductById(Id);
            return View(prod);
        }
        [HttpPost]
        public IActionResult EditProduct(ProductsVM product)
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
                ViewBag.Discount = services.GitALlDiscount();
                return View();
            }
            else
            {
                services.Edit(product);
                return Redirect("GetAdminProduct");
            }
        }
        [HttpGet]
        public IActionResult PendingProduct(int pageIndex = 1, int pageSize = 4)
        {
            var result = services.GetPendingProducts().ToPagedList(pageIndex, pageSize);
            // result.ToPagedList(pageIndex, pageSize);
            return View(result);
           
        }
        [HttpGet]
        public IActionResult Approve(int Id)
        {
            var prod = services.GetProductById(Id);
            return View(prod);
        }
        [HttpGet]
        public IActionResult ConfirmAprove(int Id)
        {
            services.ApproveProduct(Id);
            return RedirectToAction("PendingProduct");
        }
    }
}
