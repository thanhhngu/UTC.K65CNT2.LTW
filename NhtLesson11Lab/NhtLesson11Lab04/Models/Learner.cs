using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NhtLesson11Lab04.Models
{
    public class Learner
    {
        [Key]
        public int LearnerID { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        // Khóa ngoại trỏ tới Major
        [ForeignKey(nameof(Major))]
        public int? MajorID { get; set; }
        public Major? Major { get; set; }

        // Quan hệ 1-n: 1 Learner có nhiều Enrollment
        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}
