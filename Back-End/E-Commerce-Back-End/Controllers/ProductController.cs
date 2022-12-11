using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace E_Commerce_Back_End
{
    [ApiController]
    [Route("[controller]")]
    //[Authorize]
    public class ProductController : ControllerBase
    {
        private readonly IProductServices productServices;
        public ProductController(IProductServices productServices)
        {
            this.productServices = productServices;
        }
    
        [HttpGet]
        [Route("~/api/GetProducts")]
        public IActionResult GetProducts()
        {
            if (productServices.GetAllProducts() != null)
            {
                var products = productServices.GetAllProducts();
                return Ok(products);
            }
           
            return NotFound();
        }

        [HttpGet]
        [Route("~/api/GetProductById/{id}")]
        public IActionResult GetProductById(int id)
        {
            var res = productServices.GetProductById(id);
            if (res!= null)
            {
                return Ok(res);
            }
            
            return NotFound();
        }

        [HttpGet]
        [Route("~/api/GetProductByCatAndPrice/{subCat_id}&{start}&{end}")]
        public IActionResult ShowProductByPriceRange(int subCat_id ,int start,int end)
        {
            var res = productServices.GetProductBySubCatPriceRange(subCat_id,start, end);
            if (res != null)
            {
                return Ok(res);
            }

            return NotFound();
        }

        [HttpGet]
        [Route("~/api/ShowProductBySubCat/{id}")]
        public IActionResult ShowProductBySubCat(int id)
        {
            var res = productServices.GetProductBySubcategory(id);
            if (res != null)
            {
                return Ok(res);
            }

            return NotFound();
        }


        [HttpGet]
        [Route("~/api/ShowProductByCatAndPrice/{CatID}&{start_price}&{end_price}")]
        public IActionResult ShowProductByCatAndPrice(int CatID, int start_price, int end_price)
        {
            var res = productServices.GetProductByCatAndPrice(CatID, start_price, end_price);
            if (res != null)
            {
                return Ok(res);
            }

            return NotFound();
        }

        [HttpPut]
        [Route("~/api/UpdateProduct")]
        public IActionResult UpdateProduct(ProductsVM product)
        {
            if (ModelState.IsValid)
            {
                productServices.Edit(product);
                return Ok("Product Is Updated");
            }
            else
            {
                return BadRequest(" Validation Error");
            }

        }

        [HttpDelete]
        [Route("~/api/DeleteProduct")]
        public IActionResult DeleteProduct(int id)
        {
            if (productServices.GetProductById(id) != null)
            {
                productServices.DeleteProduct(id);
                return Ok("product is Deleted");
            }
            //ProductsVM p = new ProductsVM();
            return NotFound("No Product By this Id");
        }

        [HttpGet]
        [Route("~/api/ShowProductByCategory/{CatID}")]

        public async Task<IActionResult> ShowProductByCategory(int CatID)
        {
            var res = await productServices.GetProductByCategory(CatID);
            if (res != null)
            {
                return Ok(res);
            }

            return NotFound();
        }

        [HttpPost]
        [Route("~/api/AddSellerProdcuts")]
        public IActionResult AddSellerProdcuts(ProductsVM product)
        {
            if (ModelState.IsValid)
            {
                productServices.AddSellerProdcuts(product);
                return Ok("Product Is Added Successfully");
            }
            else
            {
                return BadRequest(" Validation Error");
            }

        }

        [HttpGet]
        [Route("~/api/GetNewProducts")]
        public IActionResult GetNewProducts()
        {
            if (productServices.GetNewProducts() != null)
            {
                var products = productServices.GetNewProducts();
                return Ok(products);
            }

            return NotFound();
        }

        [HttpGet]
        [Route("~/api/GetBestSeller")]
        public IActionResult GetBestSeller()
        {
            if (productServices.GetBestSeller() != null)
            {
                var products = productServices.GetBestSeller();
                return Ok(products);
            }

            return NotFound();
        }

    
    }
        
    
}
