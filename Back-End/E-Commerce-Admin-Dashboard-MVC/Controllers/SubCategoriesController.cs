using E_Commerce_Admin_Dashboard_MVC.Models;
using E_CommerceDB;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Drawing.Printing;
using X.PagedList;

namespace E_Commerce_Admin_Dashboard_MVC.Controllers
{
    [Authorize(Roles = "Admin")]

    public class SubCategoriesController : Controller
    {
        private readonly ISubcategory ISubCategorie;
        private readonly ICategory Icategory;
        private readonly IProductServices IProductServices;

        public SubCategoriesController(ISubcategory _SubCategorie, ICategory _icategory, IProductServices _IProductServices)
        {
            ISubCategorie = _SubCategorie;
            Icategory=_icategory;
            IProductServices = _IProductServices;

        }
        public IActionResult Index(int Id, int pageIndex = 1, int pageSize = 1)
        {
            return View(ISubCategorie.GetSubcategoryByCategoryId(Id).ToPagedList(pageIndex, pageSize));
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
        [HttpGet]
        public IActionResult GetProductBySubcategory(int CatId, int pageIndex = 1, int pageSize = 4)
        {
            return View("GetProductBySubcategory", IProductServices.GetProductBySubcategory(CatId).ToPagedList(pageIndex, pageSize));
        }


        public IActionResult DeleteSubCategories(int id)
        {
            ISubCategorie.Delete(id);
            return RedirectToAction("index");
        }

        public IActionResult EditSubCategory(SubcategoryModelView Subcategory)
        {

            ISubCategorie.Update(Subcategory.Id,Subcategory);

            return RedirectToAction("index");
        }
    }
}
