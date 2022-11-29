using E_CommerceDB;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace E_Commerce_Admin_Dashboard_MVC
{
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
                    Disc_Percent=discM.Disc_Percent,
                    created_at=DateTime.Now,
                    modified_at=DateTime.Now,
                    Active=true,
                    IsDeleted=false,
                    deleted_at=null

                };
                idisc.addDiscount(disc);
                return RedirectToAction("Add");
            }
        }
        [HttpGet]
        public IActionResult Show()
        {
            var disc = idisc.getAllDiscount();
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
