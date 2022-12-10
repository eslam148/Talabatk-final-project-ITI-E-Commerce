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
        public IEnumerable<ProductsVM> GetAllAdminProduct()
        {
            var data = context.Product.Where(p => p.SellerId == "09297e9d-8dd0-4d24-9230-b514a4fcff0e").Select(prod => new ProductsVM()
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


        public void AddProdcut(ProductsVM product)
        {
            List<Images> prodcutImages = new List<Images>();
            foreach (IFormFile img in product.Images)
            {
                string newName = Guid.NewGuid() + img.FileName;
                prodcutImages.Add(new Images
                {
                    Image = newName,
                    // ProductId = product.No,
                });
                FileStream fs = new FileStream(Path.Combine(Directory.GetCurrentDirectory(),
                    "Content", "Images", newName)
                    , FileMode.OpenOrCreate, FileAccess.ReadWrite);
                img.CopyTo(fs);
                fs.Position = 0;
            }
           // Product prod =
            context.Product.Add(new Product
            {
                Name = product.Name,
                created_at = product.created_at,
                modified_at = product.modified_at,
                Description = product.Description,
                inventory_Id = 1,
                discount_Id = product.DiscountID,
                Price = product.Price,
                SubCategories_Id = product.subCategory,
                Progress = 0,
                IsDeleted = false,
                Quantity = product.Qauntity,
                SelledQuantity = 0,
                SellerId = "09297e9d-8dd0-4d24-9230-b514a4fcff0e",
                Images = prodcutImages,


            });
            context.SaveChanges();

        }

        public void DeleteProduct(int id)
        {
            var product = context.Product.Where(d => d.Id == id).FirstOrDefault();
            product.IsDeleted = true;
            context.SaveChanges();
        }

        public IEnumerable<ProductsVM> GetAllExisting()
        {
            var data = context.Product.Where(p => p.IsDeleted == false && p.SelledQuantity == 0 && p.SellerId != "09297e9d-8dd0-4d24-9230-b514a4fcff0e").Select(prod => new ProductsVM()
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
            var data = context.Product.Where(p => p.SelledQuantity > 0 && p.IsDeleted == false && p.SellerId != "09297e9d-8dd0-4d24-9230-b514a4fcff0e").Select(prod => new ProductsVM()
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

        public IEnumerable<DiscountProductVM> GitALlDiscount()
        {
            var res = context.Discount.Select(d => new DiscountProductVM()
            {
                Id = d.Id,
                Name = d.Name,
                Description = d.Description
            });
            return res;
        }

        public void Edit(ProductsVM product)
        {
            var prod = context.Product.Where(p => p.Id == product.No).FirstOrDefault();
            prod.Name = product.Name;
            prod.discount_Id = product.DiscountID;
            prod.Description = product.Description;
            prod.SubCategories_Id = product.subCategory;
            prod.Price = product.Price;
            prod.Quantity = product.Qauntity;

            context.SaveChanges();
        }
    }
}
