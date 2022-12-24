using E_CommerceDB;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Dynamic;
using X.PagedList;

namespace E_Commerce_Admin_Dashboard_MVC.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {

        private readonly Iuser Iuser;
        UserManager<User> userManager;
        public UserController(Iuser _Iuser, UserManager<User> _UserManager)
        {
            Iuser = _Iuser;
            userManager=_UserManager;
        }

  
        [HttpGet]
        public async Task<IActionResult> GetBuyers(string SearchedString, int PageIndex=1, int PageSize=5)
        {
            if (!String.IsNullOrEmpty(SearchedString))
            {
                var users = await userManager.GetUsersInRoleAsync("Buyer"); //Iuser.Search(SearchedString).Where(u => u.Role == "Buyer").ToPagedList(PageIndex, PageSize);
                users =  users.Where(u => u.IsDeleted == false && u.First_Name.StartsWith(SearchedString)).ToList();
                return View(users.ToPagedList(PageIndex, PageSize));
            }
            else
            {

                var buyers = await userManager.GetUsersInRoleAsync("Buyer");// Iuser.GetAllusers().Where(u => u.Role == "Buyer").ToPagedList(PageIndex, PageSize);
                if (buyers != null)
                {
                    return View(buyers.ToPagedList(PageIndex, PageSize));
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }

            }
        }
        [HttpGet]
        public async Task<IActionResult> GetSellers(string SearchedString, int PageIndex = 1, int PageSize = 3)
        {
            if (!String.IsNullOrEmpty(SearchedString))
            {
                var users = await userManager.GetUsersInRoleAsync("Seller"); //Iuser.Search(SearchedString).Where(u => u.Role == "Buyer").ToPagedList(PageIndex, PageSize);
               users =  users.Where(u => u.IsDeleted == false && u.First_Name.StartsWith(SearchedString)).ToList();
              // var users = Iuser.Search(SearchedString).Where(u => u.Role == "Seller").ToPagedList(PageIndex, PageSize);
                return View(users.ToPagedList(PageIndex, PageSize));
            }
            else
            {
                var sellers = await userManager.GetUsersInRoleAsync("Seller"); //Iuser.GetAllusers().Where(u => u.Role == "Seller").ToPagedList(PageIndex, PageSize);
                if (sellers != null)
                {
                    return View(sellers.ToPagedList(PageIndex, PageSize));
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
        public IActionResult ConfirmDelete(string id, string FirstName, string role, string lastName)
        {
            dynamic user = new ExpandoObject();
            user.Id = id;
            user.First_Name = FirstName;
            user.Last_Name = lastName;
            user.Role = role;
            return View(user);
        }
    }
}
