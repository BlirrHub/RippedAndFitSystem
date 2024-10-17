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
        /*private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }*/

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
                if (users[i].Username == user.Username && users[i].Password == user.Password)
                {
                    user.Role = users[i].Role;
                    if(user.Role == Roles.Admin)
                    {
                        return RedirectToAction("Dashboard", "Admin");
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
