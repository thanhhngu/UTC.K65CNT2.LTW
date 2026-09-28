using System.ComponentModel.DataAnnotations;

namespace NhtLesson07Lab.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(6, ErrorMessage ="Min 6 characters")]
        [MaxLength(150, ErrorMessage = "Max 150 characters")]
        public string Name { get; set; }
    }
}
