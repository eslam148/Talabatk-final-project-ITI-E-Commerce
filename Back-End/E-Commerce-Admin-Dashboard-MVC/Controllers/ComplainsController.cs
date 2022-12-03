using E_CommerceDB;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace E_Commerce_Admin_Dashboard_MVC
{
    [Authorize(Roles = "Admin")]

    public class ComplainsController : Controller
    {
        private readonly IComplains ic;
        public ComplainsController(IComplains _ic)
        {
            this.ic = _ic;
        }

        [HttpGet]
        public IActionResult getAll(int num=1,int size=2)
        {

            var data=ic.getAllComplains().ToPagedList(num,size);
            //ViewBag.Status = ComplainsStatus.Unread;
           
                return View(data);
           
        }
        [HttpGet]
        public IActionResult getPending(int num = 1, int size = 2)
        {

            var data = ic.getPendingComplains().ToPagedList(num,size);
            ViewBag.Status = ComplainsStatus.Pending;
            return View(data);
        }
        [HttpGet]
        public IActionResult getSolved(int num = 1, int size = 2)
        {

            var data = ic.getSolvedComplains().ToPagedList(num, size);
            ViewBag.Status = ComplainsStatus.Solved;
            return View(data);
        }
        [HttpGet]
        public IActionResult Show(int id)
        {
            var data = ic.getDeatils(id);    
            return View(data);
        }
    }
}
