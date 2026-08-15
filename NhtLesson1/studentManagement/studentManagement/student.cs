using System;
using System.Collections.Generic;
using System.Text;

namespace studentManagement
{
    internal class Student
    {
        public string masv { get; set; }
        public string hoTen { get; set; }
        public DateTime? ngaySinh { get; set; }

        public bool gioiTinh { get; set; }
        public string email { get; set; }
        public string soDienThoai { get; set; }

        public string nganhHoc { get; set; }
        public float dtb { get; set; }
        public bool trangThai { get; set; }
    }
}
