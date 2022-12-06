using E_Commerce_Admin_Dashboard_MVC;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_Back_End.Controllers
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
            if (productServices.GetAllProducts()!=null)
            {
                var products = productServices.GetAllProducts();
                return Ok(products);
            }
            //ProductsVM p = new ProductsVM();
            return NotFound();
        }

        [HttpGet]
        [Route("~/api/GetProductById/{id}")]
        public IActionResult GetProductById(int id)
        {
            if (productServices.GetProductById(id) != null)
            {
                var product = productServices.GetProductById(id);
                return Ok(product);
            }
            //ProductsVM p = new ProductsVM();
            return NotFound();
        }
        //[HttpGet]
        //[Route("~/api/GetProductById")]
        //public ProductsVM GetPrById(int id)
        //{
        //    var res = productServices.GetProductById(id);
        //    if (res != null)
        //        return res;
        //    else return null;
        //}

        }
}
