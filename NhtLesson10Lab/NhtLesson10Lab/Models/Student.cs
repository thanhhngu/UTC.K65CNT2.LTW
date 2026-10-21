using MyWebApp.Models;

namespace NhtLesson10Lab.Models
{
    public class Student
    {
        public int Id { get; set; }//Mã sinh viên public
        public string? Name { get; set; } //Họ tên public
        public string? Email { get; set; } //Email
        public string? Password { get; set; }//Mật khẩu
        public Branch? Branch { get; set; }//Ngành học
        public Gender? Gender { get; set; }//Giới tính 
        public bool IsRegular { get; set; }//Hệ: true-chính qui, false-phi ca
        public string? Address { get; set; }//Địa chỉ 
        public DateTime Date0fBorth { get; set; }//Ngày sinh 
        public string? Avatar { get; set; }//Ảnh đại diện

    }

}
