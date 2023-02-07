using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace practive.Models
{
    public class Student
    {
        public long StudentId { get; set; }
        [StringLength(150, MinimumLength = 8)]
        public string? Name { get; set;}
        
        [Required]
        public DateTime DateOfBirth { get; set; }
        public string? Email { get; set;}
        public string? Address { get; set;}
        public virtual Exam? Exams { get; set; }
    }
}
