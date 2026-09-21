using Microsoft.AspNetCore.Mvc;
using STAR_PRC_SEA.Data;
using STAR_PRC_SEA.Models.Login;
using System.Linq;

namespace STAR_PRC_SEA.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = _context.Users
                .FirstOrDefault(u =>
                    u.LogName == model.LogName);

            if (user == null)
            {
                ModelState.AddModelError(
                    "",
                    "Invalid login name or password.");

                return View(model);
            }

            if (user.Password != model.Password)
            {
                ModelState.AddModelError(
                    "",
                    "Invalid login name or password.");

                return View(model);
            }

            HttpContext.Session.SetInt32(
                "UserId",
                user.UserId);

            HttpContext.Session.SetString(
                "LogName",
                user.LogName);

            HttpContext.Session.SetString(
                "UserName",
                user.UserName ?? "");

            HttpContext.Session.SetInt32(
                "AccessLevel",
                user.AccessLevel ?? 0);

            user.LastLoginDate = DateTime.Now;

            _context.SaveChanges();

            return RedirectToAction(
                "Index",
                "Home");
        }
    }
}