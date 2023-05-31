using Business.Abstract;
using Business.Schema.Category;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost]
        public IActionResult Post(CategoryRequest request)
        {
            _categoryService.AddCategory(request);
            return Ok();
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_categoryService.GetAllCategories());
        }
        [HttpGet("GetCategory")]
        public IActionResult GetCategory([FromQuery] CategoryRequest request)
        {
            var result = _categoryService.GetCategory(request);
            return Ok(result);
        }
    }
}
