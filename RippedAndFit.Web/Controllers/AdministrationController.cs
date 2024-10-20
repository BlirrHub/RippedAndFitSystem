using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RippedAndFit.Domain.Entities;
using RippedAndFit.Domain.Enums;
using RippedAndFit.Infrastructure.Data;
using RippedAndFit.Web.Models;
using System.Security.Claims;

namespace RippedAndFit.Web.Controllers
{
    [Authorize(Roles = "Admin,Trainer,Frontdesk")]
    public class AdministrationController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AdministrationController(ApplicationDbContext db)
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

        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public async Task <IActionResult> Registration(MemberModel member)
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
                    MembershipDate = DateOnly.FromDateTime(DateTime.Now),
                    MembershipExpiration = DateOnly.FromDateTime(DateTime.Now).AddDays(365),
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

            var members = new MemberListModel
            {
                Users = users,
                MemberDetails = memberDetails
            };

            return View(members);
        }

        public async Task<IActionResult> UpdateMember(int memberId)
        {
            Users? user = await _db.Users.FirstOrDefaultAsync(u => u.Id == memberId);
            MemberDetails? memberDetails = await _db.MemberDetails.FirstOrDefaultAsync(d => d.MemberId == memberId);


            if (user == null || memberDetails == null)
            {
                return NotFound();
            }

            var member = new MemberModel
            {
                User = user,
                MemberDetails = memberDetails
            };

            return View(member);
        }

        [HttpPost]
        public IActionResult UpdateMember(MemberModel member)
        {
            if (ModelState.IsValid && member.User.Id > 0 && member.MemberDetails.Id > 0)
            {
                var passwordHasher = new PasswordHasher<Users>();

                var user = new Users
                {
                    Id = member.User.Id,
                    Username = member.User.Username,
                    Password = passwordHasher.HashPassword(null, member.User.Password),
                    Role = Roles.Member
                };

                _db.Users.Update(user);
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
                    MembershipStatus = member.MemberDetails.MembershipStatus,
                    MembershipDate = member.MemberDetails.MembershipDate,
                    MembershipExpiration = member.MemberDetails.MembershipExpiration,
                    MemberId = user.Id
                };

                _db.MemberDetails.Update(memberDetails);
                _db.SaveChanges();
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteStaff(int memberId)
        {
            Users? user = await _db.Users.FirstOrDefaultAsync(u => u.Id == memberId);
            MemberDetails? memberDetails = await _db.MemberDetails.FirstOrDefaultAsync(d => d.MemberId == memberId);

            if(user != null && memberDetails != null)
            {
                _db.Users.Remove(user);
                _db.MemberDetails.Remove(memberDetails);
                _db.SaveChanges();
            }

            return RedirectToAction("Members");
        }

        public IActionResult Logs()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }
    }
}
