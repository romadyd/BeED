using BeED.Interfaces;
using BeED.Models;
using Microsoft.AspNetCore.Mvc;

namespace BeED.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private IProduct _product;

        public ProductController(IServiceProvider serviceProvider)
        {
            _product = (IProduct)serviceProvider.GetService(typeof(IProduct));
        }

        [HttpGet(Name = "GetAllProduct")]
        public async Task<EntityResult<Product>> GetAllProduct()
        {
            return await _product.GetAllProduct();
        }
    }
}
