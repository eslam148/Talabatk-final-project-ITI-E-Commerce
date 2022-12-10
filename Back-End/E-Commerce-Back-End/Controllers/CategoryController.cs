using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_Back_End.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategory ICategory;
        private readonly ISubcategory ISubCategory;
        public CategoryController(ICategory _ICategory, ISubcategory _ISubCategory)
        {

            ICategory = _ICategory;
            ISubCategory = _ISubCategory;
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
        [HttpGet]
        [Route("~/api/GetSubCategory/{id}")]
        public IActionResult GetSubCategory(int id)
        {
            var res = ISubCategory.GetSubcategoryByCategoryId(id);
            if (res != null)
            {
                return Ok(res);
            }

            return NotFound();
        }
        [HttpGet]
        [Route("~/api/GetCategoryById/{id}")]
        public IActionResult GetCategoryById(int id)
        {
            var res = ICategory.get(id);
            if (res != null)
            {
                return Ok(res);
            }

            return NotFound();
        }

    }
}
