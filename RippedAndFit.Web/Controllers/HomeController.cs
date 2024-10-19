using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RippedAndFit.Domain.Entities;
using RippedAndFit.Domain.Enums;
using RippedAndFit.Infrastructure.Data;
using RippedAndFit.Web.Models;
using System.Diagnostics;

namespace RippedAndFit.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Home()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(Users user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }

            var foundUser = await _db.Users.FirstOrDefaultAsync(u => u.Username.ToLower() == user.Username.ToLower());

            if (foundUser == null)
            {
                ModelState.AddModelError("username", "Username does not exist");
                return View(user);
            }

            var passwordHasher = new PasswordHasher<Users>();

            var result = passwordHasher.VerifyHashedPassword(foundUser, foundUser.Password, user.Password);

            if (result != PasswordVerificationResult.Success)
            {
                ModelState.AddModelError("password", "Incorrect password");
                return View(user);
            }

            HttpContext.Session.SetString("UserRole", foundUser.Role.ToString());

            if (foundUser.Role == Roles.Admin)
            {
                return RedirectToAction("Dashboard", "Administration");
            }

            if (foundUser.Role == Roles.FrontDesk || foundUser.Role == Roles.Trainer)
            {
                return RedirectToAction("Dashboard", "Administration");
            }

            if (foundUser.Role == Roles.Member)
            {
                return RedirectToAction("Dashboard", "Member");
            }

            return View(user);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
