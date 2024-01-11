using Attendance.Entities;
using Attendance.Services;
using Microsoft.AspNetCore.Mvc;

namespace Attendance.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly WeatherForecastServices _service;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
            _service = new WeatherForecastServices();
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<ActionResult> Get()
        {
            return Ok(await _service.GetList());
        }
    }
}
