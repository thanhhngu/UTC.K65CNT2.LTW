using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;
using NhtLesson10Lab.Models;

namespace NhtLesson10Lab.Controllers
{
    [Route("Admin/Student")]
    public class StudentController : Controller
    {
        private static List<Student> students = new List<Student>()
        {
            new Student() { Id = 1, Name = "Nguyen Van A", Email = "nguyenvana@example.com", Password = "password1", Branch = Branch.IT, Gender = Gender.Male, IsRegular = true, Address = "123 Main St", Date0fBorth = new DateTime(2000, 1, 1) },
            new Student() { Id = 2, Name = "Tran Thi B", Email = "tranthib@example.com", Password = "password2", Branch = Branch.BE, Gender = Gender.Female, IsRegular = false, Address = "456 Oak Ave", Date0fBorth = new DateTime(2001, 5, 15) },
            new Student() { Id = 3, Name = "Le Van C", Email = "levanc@example.com", Password = "password3", Branch = Branch.CE, Gender = Gender.Male, IsRegular = true, Address = "789 Pine Rd", Date0fBorth = new DateTime(2000, 8, 20) },
            new Student() { Id = 4, Name = "Pham Thi D", Email = "phamthid@example.com", Password = "password4", Branch = Branch.EE, Gender = Gender.Female, IsRegular = true, Address = "101 Elm St", Date0fBorth = new DateTime(2000, 12, 10) }
        };
        // GET: StudentController
        [Route("List")]
        public ActionResult Index()
        {
            return View(students);
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentController/Create
        [Route("Create")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost("Create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student student)
        {
            student.Id = students.Last<Student>().Id + 1; // Assign a new Id to the student
            if (ModelState.IsValid)
            {
                // Add the new student to the list
                students.Add(student);
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // POST: StudentController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

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
