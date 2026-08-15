using studentManagement;
using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;

Console.WriteLine("Welcome to AspNetCore MVC - UTC.K65CNT2.LTW");

string choise;
List<Student> students = new List<Student>()
{
    new Student{masv="SV001",hoTen="Nguyen Van A",ngaySinh=new DateTime(2003,1,15),
        gioiTinh=true,email="vana@gmail.com",soDienThoai="0912345678",nganhHoc="CNTT",dtb=7.5f,trangThai=true},

    new Student{masv="SV002",hoTen="Tran Thi B",ngaySinh=new DateTime(2003,5,20),
        gioiTinh=false,email="thib@gmail.com",soDienThoai="0923456789",nganhHoc="Kinh tế",dtb=8.2f,trangThai=true},

    new Student{masv="SV003",hoTen="Le Van C",ngaySinh=new DateTime(2002,11,2),
        gioiTinh=true,email="vanc@gmail.com",soDienThoai="0934567890",nganhHoc="CNTT",dtb=6.8f,trangThai=true},

    new Student{masv="SV004",hoTen="Pham Thi D",ngaySinh=new DateTime(2003,3,12),
        gioiTinh=false,email="thid@gmail.com",soDienThoai="0945678901",nganhHoc="Ngôn ngữ Anh",dtb=9.0f,trangThai=true},

    new Student{masv="SV005",hoTen="Hoang Van E",ngaySinh=new DateTime(2002,7,7),
        gioiTinh=true,email="vane@gmail.com",soDienThoai="0956789012",nganhHoc="CNTT",dtb=5.9f,trangThai=false},

    new Student{masv="SV006",hoTen="Do Thi F",ngaySinh=new DateTime(2003,9,25),
        gioiTinh=false,email="thif@gmail.com",soDienThoai="0967890123",nganhHoc="Kinh tế",dtb=7.8f,trangThai=true},

    new Student{masv="SV007",hoTen="Bui Van G",ngaySinh=new DateTime(2002,12,30),
        gioiTinh=true,email="vang@gmail.com",soDienThoai="0978901234",nganhHoc="CNTT",dtb=8.7f,trangThai=true},

    new Student{masv="SV008",hoTen="Dang Thi H",ngaySinh=new DateTime(2003,4,18),
        gioiTinh=false,email="thih@gmail.com",soDienThoai="0989012345",nganhHoc="Ngôn ngữ Anh",dtb=6.5f,trangThai=true},

    new Student{masv="SV009",hoTen="Ngo Van I",ngaySinh=new DateTime(2002,8,9),
        gioiTinh=true,email="vani@gmail.com",soDienThoai="0990123456",nganhHoc="CNTT",dtb=9.3f,trangThai=true},

    new Student{masv="SV010",hoTen="Vu Thi K",ngaySinh=new DateTime(2003,10,5),
        gioiTinh=false,email="thik@gmail.com",soDienThoai="0901234567",nganhHoc="Kinh tế",dtb=7.0f,trangThai=false},
};

do
{
    menu();
    Console.Write("Ban chon chuc nang:");
    choise = Console.ReadLine();
    switch (choise)
    {
        case "1":
            addS(students);
            break;
        case "2":
            showLIF(students);
            break;
        case "3":
            searchID(students);
            break;
        case "4":
            searchNS(students);
            break;
        case "5":
            updateS(students);
            break;
        case "6":
            deleteS(students);
            break;
        case "7":
            sortByName(students);
            break;
        case "8":
            sortByDtb(students);
            break;
        case "9":
            showHighDtb(students);
            break;
        case "10":
            showMaxDtb(students);
            break;
        case "11":
            averageDtb(students);
            break;
        case "12":
            statisticsByMajor(students);
            break;
        case "13":
            statisticsByStatus(students);
            break;
        case "14":
            Console.WriteLine("Ban da ket thuc chuc nang");
            break;
        default:
            Console.WriteLine("Ban chon sai chuc nang");
            break;
    }

} while (choise != "14");

void menu()
{
    Console.WriteLine("===========CHUC NANG===========");
    Console.WriteLine("1.\tThêm sinh viên.\r" +
        "\n2.\tHiển thị danh sách.\r" +
        "\n3.\tTìm sinh viên theo mã.\r" +
        "\n4.\tTìm gần đúng theo họ tên.\r" +
        "\n5.\tCập nhật sinh viên.\r" +
        "\n6.\tXóa sinh viên.\r" +
        "\n7.\tSắp xếp theo họ tên.\r" +
        "\n8.\tSắp xếp theo điểm trung bình.\r" +
        "\n9.\tHiển thị sinh viên có điểm từ 8 trở lên.\r" +
        "\n10.\tHiển thị sinh viên có điểm cao nhất.\r" +
        "\n11.\tTính điểm trung bình toàn bộ sinh viên.\r" +
        "\n12.\tThống kê sinh viên theo ngành.\r" +
        "\n13.\tThống kê sinh viên theo trạng thái.\r");

    Console.WriteLine("14.\tThoat ");
}

void showIF(Student s)
{
    Console.WriteLine($"Mã SV: {s.masv}");
    Console.WriteLine($"Họ tên: {s.hoTen}");
    Console.WriteLine($"Ngày sinh: {s.ngaySinh?.ToString("dd/MM/yyyy")}");
    Console.WriteLine($"Giới tính: {(s.gioiTinh ? "Nam" : "Nữ")}");
    Console.WriteLine($"Email: {s.email}");
    Console.WriteLine($"SĐT: {s.soDienThoai}");
    Console.WriteLine($"Ngành học: {s.nganhHoc}");
    Console.WriteLine($"Điểm TB: {s.dtb}");
    Console.WriteLine($"Trạng thái: {(s.trangThai ? "Đang học" : "Nghỉ")}");
    Console.WriteLine("-----------------------------");
}

void showLIF(List<Student> students)
{
    Console.WriteLine("Danh sach sinh vien");
    foreach (var item in students)
    {
        Console.WriteLine("Mã sinh viên:" + item.masv);
        Console.WriteLine("Họ và tên:" + item.hoTen);
        Console.WriteLine("--------------------------");
    }
}

void addS(List<Student> students)
{
    Console.WriteLine("Nhap thong tin sinh vien");
    Student student = new Student();
    Console.Write("Ma sv:");
    student.masv = Console.ReadLine();
    foreach (var item in students)
    {
        if (item.masv == student.masv)
        {
            Console.WriteLine("Ma sv da ton tai");
            return;
        }
    }
    Console.Write("Tên sv:");
    student.hoTen = Console.ReadLine();
    if (string.IsNullOrEmpty(student.hoTen))
    {
        Console.WriteLine("Tên sv không được để trống");
        return;
    }

    Console.Write("Ngày sinh (yyyy-MM-dd): ");
    if (DateTime.TryParse(Console.ReadLine(), out DateTime ns))
        student.ngaySinh = ns;

    Console.Write("Giới tính (nam/nữ): ");
    string gt = Console.ReadLine();
    student.gioiTinh = gt.ToLower() == "nam";

    string email;
    do
    {
        Console.Write("Email: ");
        email = Console.ReadLine();
    } while (!IsValidEmail(email));
    student.email = email;

    Console.Write("Số điện thoại: ");
    student.soDienThoai = Console.ReadLine();

    Console.Write("Ngành học: ");
    student.nganhHoc = Console.ReadLine();

    float dtb;
    do
    {
        Console.Write("Điểm trung bình (0-10): ");
    } while (!float.TryParse(Console.ReadLine(), out dtb) || dtb < 0 || dtb > 10);
    student.dtb = dtb;

    Console.Write("Trạng thái (1=đang học, 0=nghỉ): ");
    student.trangThai = Console.ReadLine() == "1";

    students.Add(student);
    Console.WriteLine("Thêm sinh viên thành công!");
}

bool IsValidEmail(string email)
{
    return Regex.IsMatch(email,
        @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
        RegexOptions.IgnoreCase);
}

void searchID(List<Student> students)
{
    Console.Write("Nhap ma sv can tim:");
    string masv = Console.ReadLine();
    foreach (var item in students)
    {
        if (item.masv == masv)
        {
            Console.WriteLine("Mã sinh viên:" + item.masv);
            Console.WriteLine("Họ và tên:" + item.hoTen);
            return;
        }
    }
    Console.WriteLine("Khong tim thay sinh vien");
}

void searchNS(List<Student> students)
{
    Console.Write("Nhap ho ten can tim:");
    string hoTen = Console.ReadLine();
    var result = students.Where(s => s.hoTen.Contains(hoTen, StringComparison.OrdinalIgnoreCase)).ToList();
    if (result.Any())
    {
        foreach (var student in result)
        {
            Console.WriteLine("Mã sinh viên:" + student.masv);
            Console.WriteLine("Họ và tên:" + student.hoTen);
        }
    }
    else
    {
        Console.WriteLine("Khong tim thay sinh vien");
    }
}

void updateS(List<Student> students)
{
    Console.Write("Nhap ma sv can cap nhat:");
    string masv = Console.ReadLine();
    var student = students.FirstOrDefault(s => s.masv == masv);
    if (student != null)
    {
        Console.Write("Ten sv moi (de trong de giu nguyen): ");
        string newName = Console.ReadLine();
        if (!string.IsNullOrEmpty(newName))
            student.hoTen = newName;
        Console.Write("Ngay sinh moi (yyyy-MM-dd, de trong de giu nguyen): ");
        string newDate = Console.ReadLine();
        if (DateTime.TryParse(newDate, out DateTime ns))
            student.ngaySinh = ns;
        Console.Write("Gioi tinh moi (nam/nữ, de trong de giu nguyen): ");
        string gt = Console.ReadLine();
        if (!string.IsNullOrEmpty(gt))
            student.gioiTinh = gt.ToLower() == "nam";
        string email;
        do
        {
            Console.Write("Email moi (de trong de giu nguyen): ");
            email = Console.ReadLine();
            if (string.IsNullOrEmpty(email)) break;
        } while (!IsValidEmail(email));
        if (!string.IsNullOrEmpty(email))
            student.email = email;
        Console.Write("So dien thoai moi (de trong de giu nguyen): ");
        string newPhone = Console.ReadLine();
        if (!string.IsNullOrEmpty(newPhone))
            student.soDienThoai = newPhone;
        Console.Write("Nganh hoc moi (de trong de giu nguyen): ");
        string newMajor = Console.ReadLine();
        if (!string.IsNullOrEmpty(newMajor))
            student.nganhHoc = newMajor;
        string dtb;
        float dtbValue = student.dtb;
        do
        {
            Console.Write("Diem trung binh moi (0-10, de trong de giu nguyen): ");
            dtb = Console.ReadLine();
            if (string.IsNullOrEmpty(dtb)) break;
        } while (!float.TryParse(dtb, out dtbValue) || dtbValue < 0 || dtbValue > 10);
        if (!string.IsNullOrEmpty(dtb))
        {
            student.dtb = dtbValue;
        }

        Console.Write("Trang thai moi (1=đang học, 0=nghỉ, de trong de giu nguyen): ");
        string newStatus = Console.ReadLine();
        if (newStatus == "1" || newStatus == "0")
            student.trangThai = newStatus == "1";
        
    }
    else
    {
        Console.WriteLine("Khong tim thay sinh vien");
    }
}

void deleteS(List<Student> students)
{
    Console.Write("Nhap ma sv can xoa:");
    string masv = Console.ReadLine();
    var student = students.FirstOrDefault(s => s.masv == masv);
    if (student != null)
    {
        students.Remove(student);
        Console.WriteLine("Xoa sinh vien thanh cong");
    }
    else
    {
        Console.WriteLine("Khong tim thay sinh vien");
    }
}

void sortByName(List<Student> students)
{
    var sortedList = students.OrderBy(s => s.hoTen).ToList();
    showLIF(sortedList);
}

void sortByDtb(List<Student> students)
{
    var sortedList = students.OrderByDescending(s => s.dtb).ToList();
    showLIF(sortedList);
}

void showHighDtb(List<Student> students)
{
    var highDtbStudents = students.Where(s => s.dtb >= 8).ToList();
    if (highDtbStudents.Any())
    {
        foreach (var student in highDtbStudents)
        {
            showIF(student);
        }
    }
    else
    {
        Console.WriteLine("Khong co sinh vien nao co diem tu 8 tro len");
    }
}

void showMaxDtb(List<Student> students)
{
    var maxDtb = students.Max(s => s.dtb);
    var maxDtbStudents = students.Where(s => s.dtb == maxDtb).ToList();
    foreach (var student in maxDtbStudents)
    {
        showIF(student);
    }
}

void averageDtb(List<Student> students)
{
    var average = students.Average(s => s.dtb);
    Console.WriteLine($"Diem trung binh toan bo sinh vien: {average:F2}");
}

void statisticsByMajor(List<Student> students)
{
    var majorGroups = students.GroupBy(s => s.nganhHoc);
    foreach (var group in majorGroups)
    {
        Console.WriteLine($"Nganh: {group.Key}, So luong sinh vien: {group.Count()}");
    }
}

void statisticsByStatus(List<Student> students)
{
    var statusGroups = students.GroupBy(s => s.trangThai);
    foreach (var group in statusGroups)
    {
        string status = group.Key ? "Dang hoc" : "Nghi";
        Console.WriteLine($"Trang thai: {status}, So luong sinh vien: {group.Count()}");
    }
}

