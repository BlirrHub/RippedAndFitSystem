using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RippedAndFit.Infrastructure.Data;

namespace RippedAndFit.Web.Controllers
{
    [Authorize (Roles = "Member")]
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

        public async Task<IActionResult> Dashboard(int userId)
        {
            var user = await _db.Users.FirstOrDefaultAsync(u => u.Id == userId);

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
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
