using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace NguyenHuuThanh_241230845_2026.ViewModels.SachViewModel
{
    public class SachViewModel
    {
        public int MaTl { get; set; }

        public string TenSach { get; set; } = null!;

        [Required(ErrorMessage = "Giá sách là bắt buộc.")]
        [Range(50, 1000, ErrorMessage = "Giá sách phải nằm trong khoảng từ 50 đến 1000.")]
        public decimal? Gia { get; set; }
        [Required(ErrorMessage = "Ảnh sách là bắt buộc.")]
        [RegularExpression(@"^.*\.(jpg|jpeg|png|gif)$", ErrorMessage = "Ảnh sách phải là một tệp hình ảnh hợp lệ.")]
        
        public string? Anh { get; set; }
    }
}
