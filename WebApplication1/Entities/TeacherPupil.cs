using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Entities
{
    public class TeacherPupil
    {
        public Pupil? Pupil { get; set; }
        
        [ForeignKey("Pupil")]
        public int PupilId { get; set; }

        public Teacher? Teacher { get; set; }
        
        [ForeignKey("Teacher")]
        public int TeacherId { get; set; }
    }
}
