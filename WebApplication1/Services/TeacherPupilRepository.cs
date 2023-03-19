using WebApplication1.DatabaseContext;
using WebApplication1.Entities;

namespace WebApplication1.Services
{
    public class TeacherPupilRepository : ITeacherPupilRepository
    {
        private readonly TeacherPupilContexts _context;

        public TeacherPupilRepository(TeacherPupilContexts context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public ICollection<Teacher> GetAllTeachersByStudent(string studentName)
        {
            return _context.Teacher.Where(t => t.TeacherPupil.Pupil.Name == studentName).ToList();
        }
    }
}
