using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NhtLesson07Lab.Models;
using System.Text.RegularExpressions;

namespace NhtLesson07Lab.Controllers
{
    public class AccountController : Controller
    {
        // GET: AccountController
        public ActionResult Index()
        {
            List<Account> accounts = new List<Account>();
            return View(accounts);
        }

        // GET: AccountController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AccountController/Create
        public ActionResult Create()
        {
            Account account = new Account();
            return View(account);
        }

        // POST: AccountController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: AccountController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AccountController/Edit/5
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

        // GET: AccountController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AccountController/Delete/5
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

        [AcceptVerbs("GET", "POST")]
        public ActionResult IsPhoneAvailable(string phone)
        {
            Regex _phoneRegex = new Regex(@"^(?:\+84|84|0)(3|5|7|8|9)\d{8}$");
            if(_phoneRegex.IsMatch(phone))
            {
                return Json(true);
            }
            return Json($"Phone number {phone} is not valid. It must start with +84, 84, or 0 followed by a valid prefix (3, 5, 7, 8, or 9) and contain a total of 10 digits.");
        }
    }
}
