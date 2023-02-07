using Microsoft.EntityFrameworkCore;
using System;

namespace practive.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }
        DbSet<Student> Students { get; set; }
        DbSet<Exam> Exams { get; set; }
        DbSet<Subject> Subjects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student()
                {
                    StudentId = 1,
                    Name = "Tien Dat",
                    DateOfBirth = new DateTime(2003,07,15),                  
                    Email = "dat1@gmail.com",
                    Address = "Ha Noi"
                });
            modelBuilder.Entity<Exam>().HasData(
                new Exam()
                {
                    ExamId = 1,
                    Score=70,
                    StudentId = 1,
                    SubjectId = 1
                });
            modelBuilder.Entity<Subject>().HasData(
                new Subject()
                {
                    SubjectId = 1,
                    SubjectName="Toan",
                    SubjectCode="T01",
                    Description="Mon toan",
                    StartDate = new DateTime(2023,01,01),
                    EndDate =  new DateTime(2025,01,01)
                });
            modelBuilder.Entity<Student>().HasData(
                new Student()
                {
                    StudentId = 2,
                    Name = "Tien Anh",
                    DateOfBirth = new DateTime(2003, 08, 15),
                    Email = "anh1@gmail.com",
                    Address = "Ha Noi"
                });
            modelBuilder.Entity<Exam>().HasData(
                new Exam()
                {
                    ExamId = 2,
                    Score = 50,
                    StudentId = 2,
                    SubjectId = 2
                });
            modelBuilder.Entity<Subject>().HasData(
                new Subject()
                {
                    SubjectId = 2,
                    SubjectName = "Van",
                    SubjectCode = "V01",
                    Description = "Mon Van",
                    StartDate = new DateTime(2023, 05, 01),
                    EndDate = new DateTime(2025, 05, 01)
                });
            modelBuilder.Entity<Student>().HasData(
                new Student()
                {
                    StudentId = 3,
                    Name = "Tien Dung",
                    DateOfBirth = new DateTime(2003, 03, 18),
                    Email = "dung1@gmail.com",
                    Address = "Ha Noi"
                });
            modelBuilder.Entity<Exam>().HasData(
                new Exam()
                {
                    ExamId = 3,
                    Score = 70,
                    StudentId = 3,
                    SubjectId = 3
                });
            modelBuilder.Entity<Subject>().HasData(
                new Subject()
                {
                    SubjectId = 3,
                    SubjectName = "Anh",
                    SubjectCode = "A01",
                    Description = "Mon English",
                    StartDate = new DateTime(2023, 03, 01),
                    EndDate = new DateTime(2025, 03, 01)
                });
        }
    }
}
