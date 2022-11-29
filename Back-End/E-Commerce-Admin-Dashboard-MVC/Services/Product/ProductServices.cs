using E_Commerce_Admin_Dashboard_MVC.Models;
using E_CommerceDB;

namespace E_Commerce_Admin_Dashboard_MVC
{
    public class ProductServices : IProductServices
    {
        private readonly LibraryContext context;
        public ProductServices(LibraryContext context)
        {
            this.context = context;

        }

        public void AddProdcut(ProductsVM product)
        {
            Product prod = new Product() { 
                Name = product.Name,
                created_at=product.created_at,
                modified_at =product.modified_at,
                Description =product.Description,
                inventory_Id=1,
                discount_Id = 1,
                Price= product.Price,
                SubCategories_Id = product.subCategory,
                Progress = 0,
                IsDeleted=false,
                Quantity=product.Qauntity,
                SelledQuantity=0,
                SellerId = "09297e9d-8dd0-4d24-9230-b514a4fcff0e"

            };
            context.Product.Add(prod);
            context.SaveChanges();
            
        }

        public void DeleteProduct(int id)
        {
            var product =context.Product.Where(d => d.Id==id).FirstOrDefault();
            product.IsDeleted = true;
            context.SaveChanges();
        }

        public IEnumerable<ProductsVM> GetAllExisting()
        {
            var data = context.Product.Where(p => p.IsDeleted == false&& p.SelledQuantity==0).Select(prod => new ProductsVM()
            {
                No = prod.Id,
                Name = prod.Name,
                Category = context.SubCategories.Where(s => s.Id == prod.SubCategories_Id).Select(b => b.BrandName).FirstOrDefault(), //prod.SubCategories_Id,
                Description = prod.Description,
                Price = prod.Price,
                created_at = prod.created_at,
                modified_at = prod.modified_at,
               // inventory_Id = prod.inventory_Id,
                Discount = context.Discount.Where(s => s.Id == prod.discount_Id).Select(b => b.Name).FirstOrDefault(),
                Progress = prod.Progress,
                IsDeleted = prod.IsDeleted,

                Qauntity = prod.Quantity,
                SelledQauntity = prod.SelledQuantity,
                SellerId = prod.Sellyer.Id
            });
            return data;
        }

        public IEnumerable<ProductsVM> GetAllSold()
        {
            var data = context.Product.Where(p => p.SelledQuantity > 0 && p.IsDeleted == false).Select(prod => new ProductsVM()
            {
                No = prod.Id,
                Name = prod.Name,
                Category = context.SubCategories.Where(s => s.Id == prod.SubCategories_Id).Select(b => b.BrandName).FirstOrDefault(), //prod.SubCategories_Id,
                Description = prod.Description,
                Price = prod.Price,
                created_at = prod.created_at,
                modified_at = prod.modified_at,
               // inventory_Id = prod.inventory_Id,
                Discount = context.Discount.Where(s => s.Id == prod.discount_Id).Select(b => b.Name).FirstOrDefault(),
                Progress = prod.Progress,
                IsDeleted = prod.IsDeleted,
                Qauntity=prod.Quantity,
                SelledQauntity=prod.SelledQuantity,
                SellerId = prod.Sellyer.Id
            }); 
            return data;
        }

        public ProductsVM GetProductById(int Id)
        {
            var res = context.Product.Where(i => i.Id == Id).Select(prod => new ProductsVM()
            {
                No = prod.Id,
                Name = prod.Name,
                Category = context.SubCategories.Where(s => s.Id == prod.SubCategories_Id).Select(b => b.BrandName).FirstOrDefault(), //prod.SubCategories_Id,
                Description = prod.Description,
                Price = prod.Price,
                created_at = prod.created_at,
                modified_at = prod.modified_at,
               // inventory_Id = prod.inventory_Id,
                Discount = context.Discount.Where(s => s.Id == prod.discount_Id).Select(b => b.Name).FirstOrDefault(),
                Progress = prod.Progress,
                IsDeleted = prod.IsDeleted,
            }).FirstOrDefault();
           // ProductsVM product = new ProductsVM();

            return res;
        }
    }
}
