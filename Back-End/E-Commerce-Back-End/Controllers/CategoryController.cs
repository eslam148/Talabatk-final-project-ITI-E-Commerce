using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_Back_End.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategory ICategory;
        public CategoryController(ICategory _ICategory)
        {

            ICategory = _ICategory;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            if (ICategory.get() != null)
            {
                var Category = ICategory.get();
                return Ok(Category);
            }

            return NotFound();
        }
       
    }
}
