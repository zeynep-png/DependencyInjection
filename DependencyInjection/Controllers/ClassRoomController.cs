using DependencyInjection.Managers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassRoomController : ControllerBase
    {
        private readonly ClassRoom _classRoom;

        // Constructor Injection ile ClassRoom ve Teacher sınıfını enjekte ediyoruz
        public ClassRoomController(ClassRoom classRoom)
        {
            _classRoom = classRoom;
        }

        [HttpGet("get-teacher-info")]
        public IActionResult GetTeacherInfo()
        {
            // ClassRoom içerisindeki Teacher bilgisini döndürüyoruz
            var teacherInfo = _classRoom.GetTeacherInfo();
            return Ok(teacherInfo);
        }
    }
}
