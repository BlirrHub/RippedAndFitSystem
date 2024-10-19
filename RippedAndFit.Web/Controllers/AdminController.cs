using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RippedAndFit.Domain.Entities;
using RippedAndFit.Domain.Enums;
using RippedAndFit.Infrastructure.Data;
using RippedAndFit.Web.Models;

namespace RippedAndFit.Web.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AdminController(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Staffs()
        {
            var users = await _db.Users.ToListAsync();
            var staffDetails = await _db.StaffDetails.ToListAsync();

            var staffs = new StaffsModel
            {
                Users = users,
                StaffDetails = staffDetails
            };

            return View(staffs);
        }

        public IActionResult UpdateStaff()
        {
            return View();
        }

        public IActionResult AddStaff()
        {
            return View();
        }
    }
}
