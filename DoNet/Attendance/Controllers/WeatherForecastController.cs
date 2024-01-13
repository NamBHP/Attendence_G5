using Attendance.Entities;
using Attendance.MAIN_OPERATION.Base;
using Attendance.Services;
using Microsoft.AspNetCore.Mvc;

namespace Attendance.Controllers
{
    /// <summary>
    /// Đây là mẫu để viết API cho một database
    /// Trước tiên phải thừa kế lại cái BaseController 
    /// Khai báo class cho cái table trong database mà cần dùng
    /// </summary
    public class WeatherForecastController : BaseController<WeatherForecast>
    {
        /// <summary>
        /// Khai báo service để dùng các hàm
        /// </summary>
        private readonly WeatherForecastServices _service = new();


        /// <summary>
        /// Ở đây khai báo API get đơn giản để lấy danh sách các dữ liệu
        /// Dùng Httpget để khai báo kiểu api
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> GetList()
        {
            return Ok(await _service.GetList());
        }

        [HttpPost]
        public Task<ActionResult> Add(WeatherForecast entity)
        {
            throw new NotImplementedException();
        }
    }
}
