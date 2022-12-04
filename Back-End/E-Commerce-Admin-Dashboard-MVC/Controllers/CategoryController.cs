using E_Commerce_Admin_Dashboard_MVC.Models;
using E_Commerce_Admin_Dashboard_MVC;
using E_CommerceDB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using X.PagedList;
using System.Drawing.Printing;
using Microsoft.AspNetCore.Authorization;
using Castle.Core.Internal;

namespace E_Commerce_Admin_Dashboard_MVC.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategory Icategory;
        public CategoryController(ICategory _category)
        {
            Icategory = _category;
        }
        [HttpGet]
        public IActionResult Index(int pageIndex = 1, int pageSize = 4)
        {
            
            return View(Icategory.get().ToPagedList(pageIndex, pageSize));
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
                return Redirect("Index");

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

        public IActionResult SearchNameCategory(string Name, int pageIndex = 1, int pageSize = 4)
        {
            //Icategory.get(Name).ToPagedList(pageIndex, pageSize);
            if (Name.IsNullOrEmpty())
            {
                return RedirectToAction("Index");
            }
            return View("index",Icategory.get(Name).ToPagedList(pageIndex, pageSize));
        }
       
    }
}
