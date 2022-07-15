
using ECommerceAPI.Application.Repositories.ProductRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductWriteRepository _productwriteService;
        private readonly IProductReadRepository _productreadService;
        public ProductsController(IProductWriteRepository productwriteService, IProductReadRepository productreadService)
        {
            _productwriteService = productwriteService;
            _productreadService = productreadService;
        }





        [HttpGet]
        public async void Get()
        {
            await _productwriteService.AddRangeAsync(new()
            {
                new()
                {
                    Name = "Product 1",
                    Price = 100,
                    Description = "Product 1 Description",
                    CreateDate = DateTime.UtcNow,
                    Quantity = 10
                    
                    
                },
                new()
                {
                    Name = "Product 2",
                    Price = 200,
                    Description = "Product 2 Description",
                    CreateDate = DateTime.UtcNow,
                    Quantity = 15
                }
            });
            await _productwriteService.SaveAsync();


        }
    }
}
