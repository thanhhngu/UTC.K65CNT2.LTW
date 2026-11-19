using System;
using System.Collections.Generic;

namespace NguyenHuuThanh_241230845_2026.Models;

public partial class Sach
{
    public int MaSach { get; set; }

    public int MaTl { get; set; }

    public string TenSach { get; set; } = null!;

    public decimal? Gia { get; set; }

    public string? Anh { get; set; }

    public virtual TheLoai MaTlNavigation { get; set; } = null!;
}
