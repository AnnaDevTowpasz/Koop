using Koop.Aplication.Suppliers.Commands.CreateSupplier;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Koop.Api.Controllers
{
    [Route("api/suppliers")]
    public class SuppliersController : BaseController
    {
        //[HttpGet("{id}")]
        //public async Task<ActionResult<DirectorDetailVm>> GetDetails(int id)
        //{
        //    var vm = await Mediator.Send(new GetDirectorDetailQuery() { DirectorId = id });
        //    return vm;
        //}

        [HttpPost]
        public async Task<IActionResult> CreateSupplier(CreateSupplierCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }
    }
}
