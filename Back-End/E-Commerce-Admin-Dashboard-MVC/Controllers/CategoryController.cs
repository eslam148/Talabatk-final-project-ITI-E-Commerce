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
            return View();
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
                var errors =
                    ModelState.SelectMany(i => i.Value.Errors.Select(x => x.ErrorMessage));

                foreach (string err in errors)ModelState.AddModelError("", err);

                return View();
            }
            else {
                Category Cat = new Category
                {
                    Name = category.Name,
                    Description = category.Description,
                    created_at = DateTime.Now,
                    deleted_at = DateTime.Now,
                    modified_at = DateTime.Now
                };
                Icategory.Add(Cat);
                return View();

            }
           
        }
    }
}
