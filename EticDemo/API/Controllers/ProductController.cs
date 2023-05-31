using Business.Abstract;
using Business.Schema.Product;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public IActionResult Post(ProductRequest productRequest)
        {
            _productService.Add(productRequest);
            return Ok();
        }
        [HttpGet]
        public IActionResult GetAll() 
        { 
            return Ok(_productService.GetAll());
        }
    }
}
