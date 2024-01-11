using Attendance.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Attendance.Base
{
    public abstract class BaseController<T> : ControllerBase
    {
        private ILogger<T> _logger;
        protected ILogger<T> Logger => _logger ??= HttpContext.RequestServices.GetService<ILogger<T>>();

    }
}
