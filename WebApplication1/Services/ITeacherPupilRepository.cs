using WebApplication1.Entities;

namespace WebApplication1.Services
{
    public interface ITeacherPupilRepository
    {
        ICollection<Teacher> GetAllTeachersByStudent(string studentName);
    }
}
