using Microsoft.AspNetCore.Mvc;
using Udep.Models;

namespace Udep.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Aquí iría la lógica de autenticación
                return RedirectToAction("Index", "Home");
            }
            return View("Index", model);
        }
    }
}