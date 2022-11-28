using E_Commerce_Admin_Dashboard_MVC.Models;
using E_CommerceDB;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace E_Commerce_Admin_Dashboard_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private LibraryContext db;
        IConfiguration con;

        public HomeController(ILogger<HomeController> logger , LibraryContext _db, IConfiguration _con)
        {
            db = _db;
            con = _con;
            _logger = logger;
        }

        public IActionResult Index()
        {
        //    var x = db.Product.ToArray();
        //    Category c = new Category
        //    {
        //        Name = "Phone",
        //        Description = "Electronic Divice",
        //    };
        //    db.Category.Add(c);
        //    db.SaveChanges();
        //    var x = db.Category.ToList();
        //    return View(x);
            //User u = new User
            //{
            //    First_Name = "sara",
            //    Last_Name = "kenady",
            //    UserName = "saraKenady",
            //    Email = "sara@gmail.com",
            //    PhoneNumber = "01098076543",
            //    Role = "Seller",
            //    IsDeleted = false,
            //    Created_at = DateTime.Now
            //};
            //db.Users.Add(u);
            //db.SaveChanges();
            //var x = db.Users.ToList();
            //return View(x);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}