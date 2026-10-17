using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NhtLesson09Lab.Areas.Admins.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên sản phẩm không được để trống")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Giá không được để trống")]
        public float Price { get; set; }

        public float SalePrice { get; set; } = 0;

        public byte Status { get; set; } = 1;

        [Required]
        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        [Column(TypeName = "date")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [StringLength(100)]
        public string? Image { get; set; }

        [StringLength(350)]
        public string? Description { get; set; }
    }
}
