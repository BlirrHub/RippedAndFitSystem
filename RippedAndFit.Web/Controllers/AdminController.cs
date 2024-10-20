using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RippedAndFit.Domain.Entities;
using RippedAndFit.Domain.Enums;
using RippedAndFit.Infrastructure.Data;
using RippedAndFit.Web.Models;

namespace RippedAndFit.Web.Controllers
{
    [Authorize(Roles = "Admin")]
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

            var staffs = new StafflListModel
            {
                Users = users,
                StaffDetails = staffDetails
            };

            return View(staffs);
        }

        public IActionResult AddStaff()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddStaff(StaffModel staff)
        {
            bool userExist = await _db.Users.FirstOrDefaultAsync(u => u.Username == staff.User.Username) != null;

            if (userExist)
            {
                ModelState.AddModelError("user.username", "Username already exist");
                return View();
            }

            if (ModelState.IsValid && !userExist)
            {
                var passwordHasher = new PasswordHasher<Users>();

                var user = new Users
                {
                    Username = staff.User.Username,
                    Password = passwordHasher.HashPassword(null, staff.User.Password),
                    Role = staff.User.Role
                };

                _db.Users.Add(user);
                _db.SaveChanges();

                var staffDetails = new StaffDetails
                {
                    FirstName = staff.StaffDetails.FirstName,
                    LastName = staff.StaffDetails.LastName,
                    DateOfBirth = staff.StaffDetails.DateOfBirth,
                    Age = staff.StaffDetails.Age,
                    Gender = staff.StaffDetails.Gender,
                    Email = staff.StaffDetails.Email,
                    PhoneNumber = staff.StaffDetails.PhoneNumber,
                    StaffId = user.Id
                };

                _db.StaffDetails.Add(staffDetails);
                _db.SaveChanges();
            }

            return View();
        }

        public async Task<IActionResult> UpdateStaff(int staffId)
        {
            Users? user = await _db.Users.FirstOrDefaultAsync(u => u.Id == staffId);
            StaffDetails? staffDetails = await _db.StaffDetails.FirstOrDefaultAsync(d => d.StaffId == staffId);

            if (user == null || staffDetails == null)
            {
                return NotFound();
            }

            var staff = new StaffModel
            {
                User = user,
                StaffDetails = staffDetails
            };

            return View(staff);
        }

        [HttpPost]
        public IActionResult UpdateStaff(StaffModel staff)
        {
            if (ModelState.IsValid)
            {
                var passwordHasher = new PasswordHasher<Users>();

                var user = new Users
                {
                    Id = staff.User.Id,
                    Username = staff.User.Username,
                    Password = passwordHasher.HashPassword(null, staff.User.Password),
                    Role = staff.User.Role
                };

                _db.Users.Update(user);
                _db.SaveChanges();

                var staffDetails = new StaffDetails
                {
                    FirstName = staff.StaffDetails.FirstName,
                    LastName = staff.StaffDetails.LastName,
                    DateOfBirth = staff.StaffDetails.DateOfBirth,
                    Age = staff.StaffDetails.Age,
                    Gender = staff.StaffDetails.Gender,
                    Email = staff.StaffDetails.Email,
                    PhoneNumber = staff.StaffDetails.PhoneNumber,
                    StaffId = user.Id
                };

                _db.StaffDetails.Update(staffDetails);
                _db.SaveChanges();
            }

            return View();
        }

        public async Task<IActionResult> RemoveStaff(int staffId)
        {
            Users? user = await _db.Users.FirstOrDefaultAsync(u => u.Id == staffId);
            StaffDetails? staffDetails = await _db.StaffDetails.FirstOrDefaultAsync(d => d.StaffId == staffId);

            if (user != null && staffDetails != null)
            {
                _db.Users.Remove(user);
                _db.StaffDetails.Remove(staffDetails);
                _db.SaveChanges();
            }

            return RedirectToAction("Staffs");
        }
    }
}
