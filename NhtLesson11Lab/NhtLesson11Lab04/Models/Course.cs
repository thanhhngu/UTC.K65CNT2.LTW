using System.ComponentModel.DataAnnotations;

namespace NhtLesson11Lab04.Models
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [Range(0, 10)]
        public int Credits { get; set; }

        // Quan hệ 1-n: 1 Course có nhiều Enrollment
        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}
