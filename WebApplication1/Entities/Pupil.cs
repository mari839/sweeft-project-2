using System.ComponentModel.DataAnnotations;
using WebApplication1.Models;

namespace WebApplication1.Entities
{
    public class Pupil
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public string Class { get; set; }
        public TeacherPupil? TeacherPupil { get; set; }
    }
}
