using System.ComponentModel.DataAnnotations;

namespace practive.Models
{
    public class Exam
    {
        public long ExamId { get; set; }
        [StringLength(100, MinimumLength = 0)]
        public int Score { get; set; }
        public long StudentId { get; set; }
        public int SubjectId { get; set; }
        public virtual List<Student>? Students { get; set; }
        public virtual List<Subject>? Subjects { get; set; }
    }
}
