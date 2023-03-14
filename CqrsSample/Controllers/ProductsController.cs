using CqrsSample.Api.Controllers.BaseController;
using CqrsSample.Business.Handlers.Products.Commands;
using CqrsSample.Business.Handlers.Products.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CqrsSample.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : BaseApiController
    {
        [HttpGet]
        public async Task<IActionResult> GetProductList()
        {
            return Ok(await Mediator.Send(new GetProductsQuery()));
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateProductCommand createProductCommand)
        {
            return Created("", await Mediator.Send(createProductCommand));
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateProductCommand updateProductCommand)
        {
            return Ok(await Mediator.Send(updateProductCommand));
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteProductCommand deleteProductCommand)
        {
            return Ok(await Mediator.Send(deleteProductCommand));
        }
    }

}
