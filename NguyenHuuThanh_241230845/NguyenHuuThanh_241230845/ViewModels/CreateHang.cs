using System.ComponentModel.DataAnnotations;

namespace NguyenHuuThanh_241230845.ViewModels
{
    public class CreateHang
    {
        [Required(ErrorMessage = "Vui lòng chọn loại hàng.")]
        public int MaLoai { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên hàng.")]
        public string TenHang { get; set; } = null!;
        [Required]
        [Range(100, 5000, ErrorMessage = "Giá phải nằm trong khoảng từ 100 đến 5000")]
        public decimal? Gia { get; set; }
        [Required]

        [RegularExpression(@"(?i)^.+\.(jpg|png|gif|tiff)$", ErrorMessage = "Tên ảnh phải có đuôi .jpg, .png, .gif hoặc .tiff.")]
        public string? Anh { get; set; }
    }
}
