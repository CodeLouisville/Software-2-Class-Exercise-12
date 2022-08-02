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
        public IActionResult GetProduct(int id)
        {
            return new JsonResult(_productLogic.GetProductById(id));
        }

        [HttpGet("{action}/{orderId}")]
        public IActionResult GetOrder(int orderId)
        {
            return new JsonResult(_productLogic.GetOrder(orderId));
        }
    }
}
