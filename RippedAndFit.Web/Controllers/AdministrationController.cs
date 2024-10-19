using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RippedAndFit.Domain.Entities;
using RippedAndFit.Domain.Enums;
using RippedAndFit.Infrastructure.Data;
using RippedAndFit.Web.Models;

namespace RippedAndFit.Web.Controllers
{
    public class AdministrationController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AdministrationController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public async Task <IActionResult> Registration(NewMember member)
        {
            bool userExist = await _db.Users.FirstOrDefaultAsync(u => u.Username == member.User.Username) != null;

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
                    Username = member.User.Username,
                    Password = passwordHasher.HashPassword(null, member.User.Password),
                    Role = Roles.Member
                };

                _db.Users.Add(user);
                _db.SaveChanges();

                var memberDetails = new MemberDetails
                {
                    FirstName = member.MemberDetails.FirstName,
                    LastName = member.MemberDetails.LastName,
                    DateOfBirth = member.MemberDetails.DateOfBirth,
                    Age = member.MemberDetails.Age,
                    Gender = member.MemberDetails.Gender,
                    Email = member.MemberDetails.Email,
                    PhoneNumber = member.MemberDetails.PhoneNumber,
                    MemberType = member.MemberDetails.MemberType,
                    MembershipStatus = MembershipStatus.Active,
                    MemberId = user.Id
                };

                _db.MemberDetails.Add(memberDetails);
                _db.SaveChanges();
            }

            return View();
        }

        public async Task<IActionResult> Members()
        {
            var users = await _db.Users.ToListAsync();
            var memberDetails = await _db.MemberDetails.ToListAsync();

            var members = new MembersModel
            {
                Users = users,
                MemberDetails = memberDetails
            };

            return View(members);
        }

        public async Task<IActionResult> UpdateMember(int memberId)
        {
            Users? user = await _db.Users.FirstOrDefaultAsync(x => x.Id == memberId);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        public IActionResult Logs()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Logout()
        {
            return RedirectToAction("Login", "Home");
        }
    }
}
