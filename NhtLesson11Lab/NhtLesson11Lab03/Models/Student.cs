using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace NhtLesson11Lab03.Models
{
    public class Student
    {
        [Display(Name = "Mã sinh viên")]
        public int Id { get; set; }//Mã sinh viên

        [Display(Name = "Họ và tên")]
        [Required(ErrorMessage = "Họ tên không được để trống")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Họ tên phải từ {2} đến {1} ký tự")]
        public string? Name { get; set; } //Họ tên

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email bắt buộc phải được nhập")]
        [RegularExpression(@"^[A-Za-z0-9._%+-]+@gmail\.com$",
        ErrorMessage = "Email phải có đuôi @gmail.com")]
        public string? Email { get; set; } //Email

        [Display(Name = "Mật khẩu")]
        [StringLength(100, MinimumLength = 8)]
        [Required(ErrorMessage = "Password không được để trống")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^A-Za-z0-9]).+$",
        ErrorMessage = "Mật khẩu phải có chữ hoa, chữ thường, chữ số và ký tự đặc biệt")]
        public string? Password { get; set; }//Mật khẩu

        [Display(Name = "Ngành học")]
        [Required(ErrorMessage = "Ngành học không được để trống")]
        public Branch? Branch { get; set; }//Ngành học

        [Display(Name = "Giới tính")]
        [Required(ErrorMessage = "Giới tính không được để trống")]
        public Gender? Gender { get; set; }//Giới tính

        [Display(Name = "Hệ đào tạo chính quy")]
        public bool IsRegular { get; set; }//Hệ: true-chính quy, false-phi chính quy

        [Display(Name = "Địa chỉ")]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        public string? Address { get; set; }//Địa chỉ

        [Display(Name = "Ngày sinh")]
        [BirthDateRange]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Ngày sinh không được để trống")]
        public DateTime DateOfBorth { get; set; }//Ngày sinh

        [Display(Name = "Điểm")]
        [Required]
        [Range(0.0, 10.0)]
        public double Score { get; set; }
    }

    public sealed class BirthDateRangeAttribute : ValidationAttribute
    {
        private static readonly DateTime MinimumDate = new(1963, 1, 1);
        private static readonly DateTime MaximumDate = new(2005, 12, 31);

        public BirthDateRangeAttribute()
        {
            ErrorMessage = "Ngày sinh phải nằm trong khoảng 01/01/1963 đến 31/12/2005.";
        }

        public override bool IsValid(object? value)
        {
            return value is DateTime date && date.Date >= MinimumDate && date.Date <= MaximumDate;
        }
    }
}

public enum Branch
{

    CNTT,

    KeToan,

    QuanTriKinhDoanh
}

public enum Gender
{

    Nam,

    Nu,

    Khac
}
