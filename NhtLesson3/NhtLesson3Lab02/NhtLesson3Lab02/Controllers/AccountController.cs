using Microsoft.AspNetCore.Mvc;
using NhtLesson3Lab02.Models;

namespace NhtLesson3Lab02.Controllers
{
    public class AccountController : Controller
    {
        List<Account> accounts = new List<Account>()
            {
                new Account()
                {
                    Id = 1,
                    Name = "Bear",
                    Email = "bear@example.com",
                    Phone = "0123456789",
                    Address = "Forest",
                    Bio = "Friendly bear",
                    Avatar = "~/AvtImg/bear.png",
                    Gender = 1,
                    Birthday = new DateTime(2000, 1, 1)
                },
                new Account()
                {
                    Id = 2,
                    Name = "Girl",
                    Email = "girl@example.com",
                    Phone = "0987654321",
                    Address = "City",
                    Bio = "Smart girl",
                    Avatar = "~/AvtImg/girl.png",
                    Gender = 0,
                    Birthday = new DateTime(2002, 5, 10)
                },
                new Account()
                {
                    Id = 3,
                    Name = "Hacker",
                    Email = "hacker@example.com",
                    Phone = "0111222333",
                    Address = "Dark Web",
                    Bio = "Code master",
                    Avatar = "~/AvtImg/hacker.png",
                    Gender = 1,
                    Birthday = new DateTime(1995, 12, 25)
                },
                new Account()
                {
                    Id = 4,
                    Name = "Penguin",
                    Email = "penguin@example.com",
                    Phone = "0999888777",
                    Address = "Antarctica",
                    Bio = "Cool penguin",
                    Avatar = "~/AvtImg/penguin.png",
                    Gender = 1,
                    Birthday = new DateTime(2010, 7, 15)
                }
            };
        public IActionResult Account()
        {
            ViewBag.Accounts = accounts;
            return View();
        }


        [Route("MyProfile", Name = "Profile")]
        public IActionResult Profile(int id)
        {
            Account account = accounts.FirstOrDefault(ac => ac.Id == id);
            ViewBag.Account = account;
            return View();
        }
    }
}
