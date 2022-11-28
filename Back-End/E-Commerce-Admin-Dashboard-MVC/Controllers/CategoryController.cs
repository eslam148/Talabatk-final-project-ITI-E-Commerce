using E_Commerce_Admin_Dashboard_MVC.Models;
using E_Commerce_Admin_Dashboard_MVC;
using E_CommerceDB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace E_Commerce_Admin_Dashboard_MVC.Controllers
{
    public class CategoryController : Controller
    {
      private readonly ICategory Icategory;
        public CategoryController(ICategory _category)
        {
            Icategory = _category;
        }
        public IActionResult Index()
        {
            
            return View(Icategory.get());
        }
        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(CategoryCreateModel category)
        {
            if (ModelState.IsValid == false)
            {
                var errors = ModelState.SelectMany(i => i.Value.Errors.Select(x => x.ErrorMessage));

                foreach (string err in errors)ModelState.AddModelError("", err);

                return View();
            }
            else {
          
                Icategory.Add(category);
                return RedirectToAction("Index");

            }
           
        }

        public IActionResult EditCategory(CategoryCreateModel category) {

            Icategory.update(category);
            return RedirectToAction("Index");

        }
        public IActionResult DeleteCategory(int id)
        {
            Icategory.delete(id);
            return RedirectToAction("Index");
        }
    }
}
