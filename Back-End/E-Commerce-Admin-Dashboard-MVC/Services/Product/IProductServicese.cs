using E_Commerce_Admin_Dashboard_MVC.Models;

namespace E_Commerce_Admin_Dashboard_MVC
{
    public interface IProductServices
    {
        public IEnumerable<ProductsVM> GetAllSold();
        public IEnumerable<ProductsVM> GetAllExisting();
        public void DeleteProduct(int Id);
        public ProductsVM GetProductById(int Id);

    }
}

