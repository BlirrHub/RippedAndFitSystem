using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RippedAndFit.Domain.Entities;
using RippedAndFit.Domain.Enums;
using RippedAndFit.Infrastructure.Data;
using RippedAndFit.Web.Models;
using System.Diagnostics;
using System.Security.Claims;

namespace RippedAndFit.Web.Controllers
{
    public class HomeController : Controller
    {
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
        public async Task<IActionResult> Login(Users user, bool rememberMe = false)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.RememberMe = rememberMe;
                return View(user);
            }

            var foundUser = await _db.Users.FirstOrDefaultAsync(u => u.Username.ToLower() == user.Username.ToLower());

            if (foundUser == null)
            {
                ModelState.AddModelError("Username", "Username does not exist");
                ViewBag.RememberMe = rememberMe;
                return View(user);
            }

            // Compare password hash
            var passwordHasher = new PasswordHasher<Users>();
            var result = passwordHasher.VerifyHashedPassword(foundUser, foundUser.Password, user.Password);

            if (result != PasswordVerificationResult.Success)
            {
                ModelState.AddModelError("Password", "Incorrect password");
                ViewBag.RememberMe = rememberMe;
                return View(user);
            }

            // Set up claims for authentication
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, foundUser.Id.ToString()),
                new Claim(ClaimTypes.Name, foundUser.Username),
                new Claim(ClaimTypes.Role, foundUser.Role.ToString())
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var authProperties = new AuthenticationProperties
            {
                IsPersistent = rememberMe,
                ExpiresUtc = rememberMe ? DateTimeOffset.UtcNow.AddDays(30) : DateTimeOffset.UtcNow.AddMinutes(30),
                AllowRefresh = true
            };

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));


            // Handle Remember Me
            if (rememberMe)
            {
                Response.Cookies.Append("Username", foundUser.Username, new CookieOptions
                {
                    Expires = DateTimeOffset.UtcNow.AddDays(30),
                    HttpOnly = true,
                    Secure = true
                });

                Response.Cookies.Append("RememberMe", "true", new CookieOptions
                {
                    Expires = DateTimeOffset.UtcNow.AddDays(30),
                    HttpOnly = true,
                    Secure = true
                });
            }
            else
            {
                // Remove the cookie if Remember Me is not checked
                if (Request.Cookies.ContainsKey("Username"))
                {
                    Response.Cookies.Delete("Username");
                }
                if (Request.Cookies.ContainsKey("RememberMe"))
                {
                    Response.Cookies.Delete("RememberMe");
                }
            }

            // Redirect user based on role
            return foundUser.Role switch
            {
                Roles.Admin => RedirectToAction("Dashboard", "Administration"),
                Roles.FrontDesk or Roles.Trainer => RedirectToAction("Dashboard", "Administration"),
                Roles.Member => RedirectToAction("Dashboard", "Member"),
                _ => View(user),
            };
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Home");
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
    