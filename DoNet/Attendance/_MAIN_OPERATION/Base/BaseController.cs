using Attendance.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Attendance.MAIN_OPERATION.Base
{
    [ApiController]
    [Route("[controller]")]
    public abstract class BaseController<T> : ControllerBase
    {
        private ILogger<T>? _logger;
        protected ILogger<T>? Logger => _logger ??= HttpContext.RequestServices.GetService<ILogger<T>>();

    }
}
