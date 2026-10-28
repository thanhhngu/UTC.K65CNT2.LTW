using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NhtLesson11Lab03.Models;

namespace NhtLesson11Lab03.Controllers
{
    public class StudentController : Controller
    {
        public static List<Student> ls = new List<Student>
        {
        new Student
        {
            Id = 1,
            Name = "Nguyễn Văn A",
            Email = "a.nguyen@gmail.com",
            Password = "12345678",
            Branch = Branch.CNTT,
            Gender = Gender.Nam,
            IsRegular = true,
            Address = "123 Lê Lợi, Q1, TP.HCM",
            DateOfBorth = new DateTime(2002, 5, 10)
        },
        new Student
        {
            Id = 2,
            Name = "Trần Thị B",
            Email = "b.tran@gmail.com",
            Password = "abcdefgh",
            Branch = Branch.KeToan,
            Gender = Gender.Nu,
            IsRegular = false,
            Address = "45 Nguyễn Huệ, Q1, TP.HCM",
            DateOfBorth = new DateTime(2000, 11, 23)
        },
        new Student
        {
            Id = 3,
            Name = "Lê Văn C",
            Email = "c.le@gmail.com",
            Password = "password1",
            Branch = Branch.QuanTriKinhDoanh,
            Gender = Gender.Nam,
            IsRegular = true,
            Address = "78 Hai Bà Trưng, Q3, TP.HCM",
            DateOfBorth = new DateTime(2003, 2, 14)
        }
        };
        // GET: StudentController
        public ActionResult Index()
        {
            return View(ls);
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student s)
        {
            if (ModelState.IsValid)
            {
                s.Id = ls.Last<Student>().Id + 1;
                ls.Add(s);
                return RedirectToAction("Index");
            }
            return View(s);
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
