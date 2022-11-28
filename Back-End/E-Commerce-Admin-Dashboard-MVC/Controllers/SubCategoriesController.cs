using E_Commerce_Admin_Dashboard_MVC.Models;
using E_CommerceDB;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_Admin_Dashboard_MVC.Controllers
{
    public class SubCategoriesController : Controller
    {
        private readonly ISubcategory ISubCategorie;
        private readonly ICategory Icategory;
        public SubCategoriesController(ISubcategory _SubCategorie, ICategory _icategory)
        {
            ISubCategorie = _SubCategorie;
            Icategory=_icategory;
        }
        public IActionResult Index(int Id)
        {
            return View(ISubCategorie.GetSubcategoryByCategoryId(Id));
        }
        [HttpGet]
        public IActionResult Add() {
            ViewBag.Category = Icategory.get();
            return View();
        }
        [HttpPost]
        public IActionResult Add(SubcategoryModelView subcategoryModelView)
        {
            if (ModelState.IsValid == false)
            {
                var errors = ModelState.SelectMany(i => i.Value.Errors.Select(x => x.ErrorMessage));

                foreach (string err in errors) ModelState.AddModelError("", err);

                return RedirectToAction("Add");
            }
            else
            {

                ISubCategorie.Add(subcategoryModelView);
                return RedirectToAction("Index");

            } 
        }
    }
}
