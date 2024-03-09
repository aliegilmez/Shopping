using Microsoft.AspNetCore.Mvc;

namespace Shopping.Services.Api.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ApiController : ControllerBase
    {
    }
}