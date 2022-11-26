using E_Commerce_Admin_Dashboard_MVC.Models;
using E_CommerceDB;

namespace E_Commerce_Admin_Dashboard_MVC.Services
{
    public class ProductServices : IProductServices
    {
        private readonly LibraryContext context;
        public ProductServices(LibraryContext context)
        {
            this.context = context;
                
        }
        public IEnumerable<ProductsVM> GetAllExisting()
        {
            var data = context.Product.Where(p => p.Progress == 0).Select(prod => new ProductsVM()
            {
                Id=prod.Id,
                Name =prod.Name,
                category_Id=prod.category_Id,
                Description =prod.Description,
                Price=prod.Price,
                created_at=prod.created_at,
                modified_at=prod.modified_at,
                inventory_Id=prod.inventory_Id,
                discount_Id=prod.discount_Id,
                Progress=prod.Progress,
                IsDeleted=prod.IsDeleted,
            });
            return data;
        }

        public IEnumerable<ProductsVM> GetAllSold()
        {
            var data = context.Product.Where(p => p.Progress > 0).Select(prod => new ProductsVM()
            {
                Id = prod.Id,
                Name = prod.Name,
                category_Id = prod.category_Id,
                Description = prod.Description,
                Price = prod.Price,
                created_at = prod.created_at,
                modified_at = prod.modified_at,
                inventory_Id = prod.inventory_Id,
                discount_Id = prod.discount_Id,
                Progress = prod.Progress,
                IsDeleted = prod.IsDeleted,
            });
            return data;
        }
    }
}
