using E_CommerceDB;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_Admin_Dashboard_MVC
{
    public class ComplainsController : Controller
    {
        private readonly IComplains ic;
        public ComplainsController(IComplains _ic)
        {
            this.ic = _ic;
        }

        [HttpGet]
        public IActionResult getAll()
        {

            var data=ic.getAllComplains();
            //ViewBag.Status = ComplainsStatus.Unread;
            return View(data);
        }
        [HttpGet]
        public IActionResult getPending()
        {

            var data = ic.getPendingComplains();
            ViewBag.Status = ComplainsStatus.Pending;
            return View(data);
        }
        [HttpGet]
        public IActionResult getSolved()
        {

            var data = ic.getSolvedComplains();
            ViewBag.Status = ComplainsStatus.Solved;
            return View(data);
        }
    }
}
