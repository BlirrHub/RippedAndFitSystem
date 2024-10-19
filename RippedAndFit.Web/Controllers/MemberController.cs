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
    }
}
