using E_Commerce_Admin_Dashboard_MVC.Services;
using E_CommerceDB;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace E_Commerce_Admin_Dashboard_MVC.Controllers
{
    [Authorize(Roles = "Admin")]

    public class OrderController : Controller
    {
        private readonly Iorder Iorder;
        public OrderController(Iorder _Iorder)
        {
            Iorder = _Iorder;
        }
        [HttpGet]
        public IActionResult Index(int PageIndex = 1, int PageSize = 2)
        {
            var orders = Iorder.GetOrders().ToPagedList(PageIndex, PageSize);
            return View(orders);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Iorder.Delete(id);
            return RedirectToAction("GetPendingOrders");
        }
        [HttpGet]
        public IActionResult GetPendingOrders(int PageIndex = 1, int PageSize = 2)
        {
            var pending = Iorder.GetPendingOrders().ToPagedList(PageIndex, PageSize);
            return View(pending);
        }
        [HttpGet]
        public IActionResult GetDeliveredOrders(int PageIndex = 1, int PageSize = 2)
        {
            var delivered = Iorder.GetDeliveredOrders().ToPagedList(PageIndex, PageSize);
            return View(delivered);
        }
        [HttpGet]
        public IActionResult GetShippingOrders(int PageIndex = 1, int PageSize = 2)
        {
            var delivered = Iorder.GetShippingOrders().ToPagedList(PageIndex, PageSize);
            return View(delivered);
        }

        [HttpGet]
        public IActionResult ChangeOrderProgressShipping(int id)
        {
            Iorder.updateProgress(id, 1);
            return RedirectToAction("GetPendingOrders");
        }
      

        [HttpGet]
        public IActionResult ChangeOrderProgressDelivered(int id)
        {
            Iorder.updateProgress(id, 2);
            return RedirectToAction("GetShippingOrders");
        }
      
    }
}
