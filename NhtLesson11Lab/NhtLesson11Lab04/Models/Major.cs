using System.ComponentModel.DataAnnotations;

namespace NhtLesson11Lab04.Models
{
    public class Major
    {
        [Key]
        public int MajorID { get; set; }

        [Required]
        [StringLength(100)]
        public string MajorName { get; set; }

        // Quan hệ 1-n: 1 Major có nhiều Learner
        public ICollection<Learner>? Learners { get; set; }
    }
}
