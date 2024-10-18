using Microsoft.AspNetCore.Mvc;
using RippedAndFit.Domain.Entities;
using RippedAndFit.Domain.Enums;
using RippedAndFit.Infrastructure.Data;

namespace RippedAndFit.Web.Controllers
{
    public class StaffController : Controller
    {
        private readonly ApplicationDbContext _db;

        public StaffController(ApplicationDbContext db)
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
        public IActionResult Registration(NewMember member)
        {
            var user = new Users
            {
                Id = _db.Users.ToList().Count + 1,
                Username = member.User.Username,
                Password = member.User.Password,
                Role = Roles.Member
            };

            var memberDetails = new MemberDetails
            {
                Id = _db.MemberDetails.ToList().Count + 1,
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

            _db.Users.Add(user);
            _db.MemberDetails.Add(memberDetails);
            _db.SaveChanges();
            return RedirectToAction("Registraion", "Admin");
        }

        public IActionResult Members()
        {
            return View();
        }

        public IActionResult Logs()
        {
            return View();
        }
    }
}
