using E_CommerceDB;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Dynamic;

namespace E_Commerce_Admin_Dashboard_MVC.Controllers
{
    public class UserController : Controller
    {

        private readonly Iuser Iuser;
        public UserController(Iuser _Iuser)
        {
            Iuser = _Iuser;
        }

  
        [HttpGet]
        public IActionResult GetBuyers(string SearchedString)
        {
            if (!String.IsNullOrEmpty(SearchedString))
            {
                var users = Iuser.Search(SearchedString).Where(u => u.Role == "Buyer");
                return View(users);
            }
            else
            {
                var buyers = Iuser.GetAllusers().Where(u => u.Role == "Buyer");
                if (buyers != null)
                {
                    return View(buyers);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }

            }
        }
        [HttpGet]
        public IActionResult GetSellers(string SearchedString)
        {
            if (!String.IsNullOrEmpty(SearchedString))
            {
                var users = Iuser.Search(SearchedString).Where(u => u.Role == "Seller");
                return View(users);
            }
            else
            {
                var sellers = Iuser.GetAllusers().Where(u => u.Role == "Seller");
                if (sellers != null)
                {
                    return View(sellers);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
          
        }

        [HttpGet]
        public IActionResult DeleteUser(string id)
        {

           var user= Iuser.DeleteUser(id);
            if (user.Role == "Buyer")
            {
                return RedirectToAction("GetBuyers");
            }else if(user.Role == "Seller")
            {
                return RedirectToAction("GetSellers");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
                
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
