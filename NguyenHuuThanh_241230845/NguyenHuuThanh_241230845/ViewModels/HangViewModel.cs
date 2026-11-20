using System.ComponentModel.DataAnnotations;

namespace NguyenHuuThanh_241230845.ViewModels
{
    public class HangViewModel
    {

        public int Maloai { get; set; }

        public string TenHang { get; set; } = null!;
        [Required(ErrorMessage ="phai nhap")]
        [Range(100, 5000, ErrorMessage = "100-5000")]
        public decimal? Gia { get; set; }
        [Required(ErrorMessage = "phai nhap")]
        [RegularExpression(@"(?i)^.+\.(jpg|png|gif|tiff)$", ErrorMessage = "Tên ảnh phải có đuôi .jpg, .png, .gif hoặc .tiff.")]
        public string? Anh { get; set; }
    }
}
