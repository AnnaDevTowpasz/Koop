using Koop.Aplication.Products.Commands.CreateProduct;
using Koop.Aplication.Products.Commands.DeleteProduct;
using Koop.Aplication.Products.Querries.GetProductDetail;
using Koop.Aplication.Products.Querries.GetProductsQuery;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Koop.Api.Controllers
{
    [Route("api/products")]
    public class ProductsController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<ProductsVM>> GetProducts()
        {
            var vm = await Mediator.Send(new GetProductsQuery());
            return vm;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDetailVm>> GetDetails(int id)
        {
            var vm = await Mediator.Send(new GetProductDetailQuery() { ProductId = id });
            return vm;
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteProduct(DeleteProductCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }
    }
}
