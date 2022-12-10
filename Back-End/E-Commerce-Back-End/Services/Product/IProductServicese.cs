using E_Commerce_Back_End;

namespace E_Commerce_Back_End
{
    public interface IProductServices
    {
        public IEnumerable<ProductsVM> GetAllProducts();
        public IEnumerable<ProductsVM> GetAllSold();
        public IEnumerable<ProductsVM> GetAllExisting();
        public IEnumerable<ProductsVM> GetAllAdminProduct();
        public void DeleteProduct(int Id);
        public ProductsVM GetProductById(int Id);
        public void AddProdcut(ProductsVM product);
        public void Edit(ProductsVM product);
        public IEnumerable<DiscountProductVM> GitALlDiscount();
        public IEnumerable<ProductsVM> GetProductBySubcategory(int CatId);
        public IEnumerable<ProductsVM> GetProductBySubCatPriceRange(int SubCat_id,int start_price,int end_price);
        public IEnumerable<ProductsVM> GetProductByCatAndPrice(int CatID, int start_price, int end_price);
        public Task<IEnumerable<ProductsVM>> GetProductByCategory(int CatID);
        public void AddSellerProdcuts(ProductsVM product);
        public IEnumerable<ProductsVM> GetNewProducts();
        public IEnumerable<ProductsVM> GetBestSeller();

    }
}

