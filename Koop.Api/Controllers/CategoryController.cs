using Koop.Aplication.Categories.Commands.CreateCategory;
using Koop.Aplication.Categories.Commands.DeleteCategory;
using Koop.Aplication.Categories.Querries.GetCategoriesQuery;
using Koop.Aplication.Categories.Querries.GetCategoryDetail;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Koop.Api.Controllers
{
    [Route("api/categories")]
    public class CategoryController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<CategoriesVM>> GetCategories()
        {
            var vm = await Mediator.Send(new GetCategoriesQuery());
            return vm;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryDetailVm>> GetDetails(int id)
        {
            var vm = await Mediator.Send(new GetCategoryDetailQuery() { CategoryId = id });
            return vm;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }

        //[HttpPost]
        //public async Task<IActionResult> DeleteCategory(DeleteCategoryCommand command)
        //{
        //    var result = await Mediator.Send(command);
        //    return Ok(result);
        //}
    }
}
