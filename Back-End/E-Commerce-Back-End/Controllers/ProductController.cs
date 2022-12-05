using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_Back_End.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public String Index()
        {
            return "Hello";
        }
    }
}
