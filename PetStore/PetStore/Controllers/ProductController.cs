using Microsoft.AspNetCore.Mvc;
using PetStore.Logic;

namespace PetStore.Controllers
{
    [ApiController]
    [Route("{controller}")]
    public class ProductController : Controller
    {
        private readonly IProductLogic _productLogic;

        public ProductController(IProductLogic productLogic)
        {
            _productLogic = productLogic;
        }

        [HttpGet("{action}/{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            return new JsonResult(await _productLogic.GetProductByIdAsync(id));
        }

        [HttpGet("{action}/{orderId}")]
        public async Task<IActionResult> GetOrder(int orderId)
        {
            return new JsonResult(await _productLogic.GetOrderAsync(orderId));
        }
    }
}
