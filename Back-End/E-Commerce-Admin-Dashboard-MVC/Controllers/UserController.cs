using E_CommerceDB;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Dynamic;

namespace E_Commerce_Admin_Dashboard_MVC.Controllers
{
    public class UserController : Controller
    {
        
        LibraryContext db;
        public UserController(LibraryContext _db)
        {
            db = _db;
        }


        [HttpGet]
        public IActionResult GetBuyers()
        {
            var buyers = db.Users.Where(u=>u.Role=="buyer" && u.IsDeleted == false).ToList();
            if (buyers != null)
            {
                return View(buyers);
            }
            else
            {
                return RedirectToAction("Index","Home");
            }   
        }
        [HttpGet]
        public IActionResult GetSellers()
        {
            var sellers = db.Users.Where(u => u.Role == "seller" && u.IsDeleted == false).ToList();
            if (sellers != null)
            {
                return View(sellers);
            }
            else
            {
                return RedirectToAction("Index","Home");
            }
        }

        [HttpGet]
        public IActionResult DeleteBuyer(string id)
        {

            var user = db.Users.FirstOrDefault(u => u.Id == id);
            user.IsDeleted = true;
            db.SaveChanges();
            return RedirectToAction("GetBuyers");

        }
        [HttpGet]
        public IActionResult DeleteSeller(string id)
        {

            var user = db.Users.FirstOrDefault(u => u.Id == id);
            user.IsDeleted = true;
            db.SaveChanges();
            return RedirectToAction("GetSellers");

        }
    

        [HttpGet]
        public IActionResult ConfirmDelete(string id, string FirstName, string role)
        {
            dynamic user = new ExpandoObject();
            user.Id = id;
            user.First_Name=FirstName; 
            user.Role= role;
            return View(user);
        }
    }
}
