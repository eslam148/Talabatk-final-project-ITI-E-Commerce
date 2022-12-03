using E_Commerce_Admin_Dashboard_MVC.Models;
using E_CommerceDB;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace E_Commerce_Admin_Dashboard_MVC.Controllers
{
    [Authorize(Roles = "Admin")]

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
            //var x = db.Product.ToArray();/
            //Category c = new Category
            //{
            //    Name= "Phone",
            //    Description="Electronic Divice",
            //};
            //db.Category.Add(c);
            //db.SaveChanges();
            var x = db.Category.ToList();
            return View(x);
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