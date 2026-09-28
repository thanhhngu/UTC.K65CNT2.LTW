using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace NhtLesson07Lab.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(6, ErrorMessage = "Min 6 characters")]
        [MaxLength(150, ErrorMessage = "Max 150 characters")]
        public string Name { get; set; }
        [ValidationAttributes]
        public string Image { get; set; }
        public float Price { get; set; }
        [Remote(action: "ValidateSalePrice", controller: "Product")]
        public float SalePrice { get; set; }
        [MaxLength(1500, ErrorMessage = "Max 1500 characters")]
        [SensitiveWordValidation]
        public string Description { get; set; }
    }
}
