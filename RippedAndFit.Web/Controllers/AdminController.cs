using Microsoft.AspNetCore.Mvc;
using RippedAndFit.Domain.Entities;
using RippedAndFit.Domain.Enums;
using RippedAndFit.Infrastructure.Data;

namespace RippedAndFit.Web.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AdminController(ApplicationDbContext db)
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
            bool userExist = _db.Users.FirstOrDefault(u => u.Username == member.User.Username) != null;

            if (userExist)
            {
                ModelState.AddModelError("user.username", "Username already exist");
                return View();
            }

            if (ModelState.IsValid && !userExist)
            {
                var user = new Users
                {
                    Username = member.User.Username,
                    Password = member.User.Password,
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

        public IActionResult Staffs()
        {
            return View();
        }

        public IActionResult Members()
        {
            var members = _db.MemberDetails.ToList();

            return View(members);
        }

        public IActionResult Logs()
        {
            return View();
        }
    }
}
