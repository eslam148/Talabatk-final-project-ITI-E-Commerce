using Microsoft.AspNetCore.Mvc;
namespace E_Commerce_Back_End
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductServices productServices;
        public ProductController(IProductServices productServices)
        {
            this.productServices = productServices;
        }
        [HttpGet]
        public string Index()
        {
            return "Hello";
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
    }
        
    
}
