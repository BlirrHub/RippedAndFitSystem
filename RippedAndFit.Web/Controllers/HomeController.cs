using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Login(Users user)
        {
            var users = _db.Users.ToList();

            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Username.ToLower() == user.Username.ToLower() && users[i].Password == user.Password)
                {
                    HttpContext.Session.SetString("UserRole", users[i].Role.ToString());

                    if (users[i].Role == Roles.Admin)
                    {
                        return RedirectToAction("Dashboard", "Administration");
                    }

                    if (users[i].Role == Roles.FrontDesk || users[i].Role == Roles.Trainer)
                    {
                        return RedirectToAction("Dashboard", "Administration");
                    }

                    if (users[i].Role == Roles.Member)
                    {
                        return RedirectToAction("Dashboard", "Member");
                    }
                }
            }

            return RedirectToAction("Login");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
