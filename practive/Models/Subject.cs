using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace practive.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }
        [StringLength(150, MinimumLength = 8)]
        public string? SubjectName { get; set; }

        [StringLength(20, MinimumLength = 2)]

        public string? SubjectCode { get; set; }
        [StringLength(500)]
        public string? Description { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        public virtual Exam? Exams { get; set; }
    }
}
