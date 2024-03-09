using Atlas.Framework.CleanArchitecture.Handling;
using Atlas.Framework.Web.Contract;
using Microsoft.AspNetCore.Mvc;
using Shopping.Services.Application.Query.UseCases.v1;
using Shopping.Services.Library.Dto.CommonModels;

namespace Shopping.Services.Api.Controllers.v1
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/customers")]
    [ApiController]
    public class CustomersController : ApiController
    {
        private readonly IApplicationMediator _applicationMediator;

        public CustomersController(IApplicationMediator applicationMediator)
        {
            _applicationMediator = applicationMediator;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            var request = new GetCustomerByIdRequest { Id = id };

            var response = await _applicationMediator.SendAsync(request);

            return Ok(new RestResponse<CustomerDto>()
            {
                Success = true,
                Payload = response
            });
        }
    }
}
