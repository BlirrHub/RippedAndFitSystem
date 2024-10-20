using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RippedAndFit.Infrastructure.Data;
using System.Security.Claims;

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

        public async Task<IActionResult> Dashboard()
        {
            var userIdClaim = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(userIdClaim))
            {
                // If the user is not authenticated, redirect to login
                return RedirectToAction("Login", "Home");
            }

            int userId = int.Parse(userIdClaim);
            var user = await _db.Users.FirstOrDefaultAsync(u => u.Id == userId);

            if (user == null)
            {
                return NotFound("User not found.");
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
