using Microsoft.AspNetCore.Mvc;

namespace RippedAndFit.Web.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Registration()
        {
            return View();
        }
    }
}
