using E_CommerceDB;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using X.PagedList;

namespace E_Commerce_Admin_Dashboard_MVC
{
    [Authorize(Roles = "Admin")]

    public class DiscountController : Controller
    {
        private readonly IDiscount idisc;
        public DiscountController(IDiscount _idisc)
        {
            this.idisc = _idisc;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(DiscountModel discM)
        {
            if(ModelState.IsValid==false)
            {
                var err = ModelState.SelectMany(e => e.Value.Errors.Select(m => m.ErrorMessage));
                foreach (string e in err) ModelState.AddModelError("", e);
                return View();
            }
            else
            {
                var disc = new Discount {
                    Name=discM.Name,
                    Description=discM.Description,
                    DescriptionAr = discM.DescriptionAr,
                    Disc_Percent=discM.Disc_Percent,
                    created_at=DateTime.Now,
                    modified_at=DateTime.Now,
                    Active=true,
                    IsDeleted=false,
                    deleted_at=null

                };
                idisc.addDiscount(disc);
                return RedirectToAction("Home");
            }
        }
        [HttpGet]
        public IActionResult Show(int num=1,int size=2)
        {
            var disc = idisc.getAllDiscount().ToPagedList(num,size);
            return View(disc);

        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            idisc.deleteDiscount(id);
            return RedirectToAction("Show");

        }

    }
}
