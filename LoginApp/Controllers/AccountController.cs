using Microsoft.AspNetCore.Mvc;
using LoginApp.Models;

namespace LoginFormDemo.Controllers
{
    public class AccountController : Controller
    {
        // GET: /Account/Login
        public IActionResult Login()
        {
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Dummy check: username = admin, password = 1234
                if (model.Username == "admin" && model.Password == "1234")
                {
                    // Redirect to dashboard
                    return RedirectToAction("Dashboard");
                }
                else
                {
                    ViewBag.Error = "Invalid credentials";
                }
            }

            return View(model);
        }

        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
