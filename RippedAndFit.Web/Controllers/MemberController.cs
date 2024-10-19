using Microsoft.AspNetCore.Mvc;
using RippedAndFit.Infrastructure.Data;

namespace RippedAndFit.Web.Controllers
{
    public class MemberController : Controller
    {
        private readonly ApplicationDbContext _db;

        public MemberController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Notification()
        {
            return View();
        }

        public IActionResult History()
        {
            return View();
        }

        public IActionResult Renew()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }
    }
}
