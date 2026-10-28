using Microsoft.Identity.Client.NativeInterop;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NhtLesson11Lab04.Models
{


    public class Enrollment
    {
        [Key]
        public int EnrollmentID { get; set; }

        [ForeignKey(nameof(Course))]
        public int CourseID { get; set; }
        public Course? Course { get; set; }

        [ForeignKey(nameof(Learner))]
        public int LearnerID { get; set; }
        public Learner? Learner { get; set; }

        public float? Grade { get; set; }
    }
}
