using E_Commerce_Admin_Dashboard_MVC.Controllers;
using E_CommerceDB;

namespace E_Commerce_Admin_Dashboard_MVC
{
    public class CategoryService : ICategory
    {
        private LibraryContext db;
        IConfiguration con;

        public CategoryService(LibraryContext _db, IConfiguration _con)
        {
            db = _db;
            con = _con;
        }
        public void Add(Category category)
        {
            db.Category.Add(category);
            save();
        }

        public void save()
        {
            db.SaveChanges();
        }
    }
}
