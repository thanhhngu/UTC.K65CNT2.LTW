using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NguyenHuuThanh_241230845_QLTS2.Models;

public partial class TaiSan
{
    public int MaTs { get; set; }

    public int MaLoai { get; set; }

    public string TenTs { get; set; } = null!;
    [Required(ErrorMessage = "phai nhap")]
    [Range(1, 2000, ErrorMessage = ("1-2000"))]
    public decimal? NguyenGia { get; set; }
    [RegularExpression(@"(?i)^.+\.(jpg|png|gif|tiff)$", ErrorMessage = "Tên ảnh phải có đuôi .jpg, .png, .gif hoặc .tiff.")]

    public string? Anh { get; set; }
    [ValidateNever]

    public virtual LoaiTaiSan MaLoaiNavigation { get; set; } = null!;
}
