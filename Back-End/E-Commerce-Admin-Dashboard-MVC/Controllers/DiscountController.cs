using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_Admin_Dashboard_MVC
{
    public class DiscountController : Controller
    {
        private readonly IDiscount IDisc;
        public DiscountController(IDiscount _IDisc)
        {
            this.IDisc = _IDisc;
        }
        public IActionResult Add()
        {

            return View();
        }
    }
}
