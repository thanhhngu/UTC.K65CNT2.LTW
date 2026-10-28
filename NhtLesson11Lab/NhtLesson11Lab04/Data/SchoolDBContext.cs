using Microsoft.EntityFrameworkCore;
using NhtLesson11Lab04.Models;

namespace NhtLesson11Lab04.Data
{
    public class SchoolDBContext : DbContext
    {
        public SchoolDBContext(DbContextOptions<SchoolDBContext> options) : base(options) { }

        public DbSet<Major> Majors { get; set; }
        public DbSet<Learner> Learners { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Major 1 - n Learner
            modelBuilder.Entity<Learner>()
                .HasOne(l => l.Major)
                .WithMany(m => m.Learners)
                .HasForeignKey(l => l.MajorID)
                .OnDelete(DeleteBehavior.SetNull);

            // Learner 1 - n Enrollment
            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Learner)
                .WithMany(l => l.Enrollments)
                .HasForeignKey(e => e.LearnerID)
                .OnDelete(DeleteBehavior.Cascade);

            // Course 1 - n Enrollment
            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Course)
                .WithMany(c => c.Enrollments)
                .HasForeignKey(e => e.CourseID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
