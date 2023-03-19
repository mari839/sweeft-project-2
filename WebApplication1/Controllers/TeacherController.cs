using Microsoft.AspNetCore.Mvc;
using WebApplication1.Entities;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/teachers")]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherPupilRepository _teacherPupilRepository;

        public TeacherController(ITeacherPupilRepository teacherPupilRepository)
        {
            _teacherPupilRepository= teacherPupilRepository ?? throw new ArgumentNullException(nameof(teacherPupilRepository));
        }

        [HttpGet("{studentName}")]
        public IEnumerable<Teacher> GetTeachers(string studentName)
        {
            var teacher = _teacherPupilRepository.GetAllTeachersByStudent(studentName);
            return teacher;
        }
    }
}
