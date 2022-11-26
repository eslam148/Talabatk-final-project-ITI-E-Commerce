using E_Commerce_Admin_Dashboard_MVC.Models;

namespace E_Commerce_Admin_Dashboard_MVC.Services
{
    public interface IProductServices
    {
        public IEnumerable<ProductsVM> GetAllSold();
        public IEnumerable<ProductsVM> GetAllExisting();

    }
}

