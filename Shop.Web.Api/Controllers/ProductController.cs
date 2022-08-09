using Microsoft.AspNetCore.Mvc;
using Shop.Application.Interfaces;
using Shop.Application.ViewModels;

namespace Shop.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            ProductViewModel model = _productService.GetProducts();
            return Ok(model);
        }
    }
}
