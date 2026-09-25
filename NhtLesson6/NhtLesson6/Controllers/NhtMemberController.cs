using Microsoft.AspNetCore.Mvc;
using NhtLesson6.Models;

namespace NhtLesson6.Controllers
{
    public class NhtMemberController : Controller
    {
        private static readonly List<NhtMember> _members = new List<NhtMember>()
        {
            new NhtMember { Id = Guid.NewGuid().ToString(), UserName = "nht", Email = "nht@example.com", Password = "password123", FullName = "Nht" },
            new NhtMember { Id = Guid.NewGuid().ToString(), UserName = "john_doe", Email = "john.doe@example.com", Password = "password123", FullName = "John Doe" },
            new NhtMember { Id = Guid.NewGuid().ToString(), UserName = "jane_smith", Email = "jane.smith@example.com", Password = "password456", FullName = "Jane Smith" },
            new NhtMember { Id = Guid.NewGuid().ToString(), UserName = "alice_jones", Email = "alice.jones@example.com", Password = "password789", FullName = "Alice Jones" },
            new NhtMember { Id = Guid.NewGuid().ToString(), UserName = "bob_brown", Email = "bob.brown@example.com", Password = "password101", FullName = "Bob Brown" }
        };
        public IActionResult Index()
        {
            return View(_members);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(NhtMember member)
        {
            member.Id = Guid.NewGuid().ToString();
            _members.Add(member);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(string id)
        {
            var member = _members.FirstOrDefault(m => m.Id == id);
            if (member == null)
            {
                return NotFound();
            }
            return View(member);
        }

        [HttpPost]
        public IActionResult Edit(NhtMember member)
        {
            var m = _members.FirstOrDefault(m => m.Id == member.Id);
            if (m == null)
            {
                return NotFound();
            }
            m.UserName = member.UserName;
            m.Email = member.Email;
            m.Password = member.Password;
            m.FullName = member.FullName;
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(string id)
        {
            var member = _members.FirstOrDefault(m => m.Id == id);
            return View(member);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult NhtDelete(string id)
        {
            var member = _members.FirstOrDefault(m => m.Id == id);
            if (member == null)
            {
                return NotFound();
            }
            _members.Remove(member);
            return RedirectToAction(nameof(Index));

        }

        public IActionResult Details(string id)
        {
            var member = _members.FirstOrDefault(m => m.Id == id);
            if (member == null)
            {
                return NotFound();
            }
            return View(member);
        }
    }
}
