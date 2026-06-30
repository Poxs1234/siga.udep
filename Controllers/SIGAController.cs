using Microsoft.AspNetCore.Mvc;

namespace siga.udep.Controllers // Asegúrate de que el namespace coincida con tu proyecto
{
    public class SIGAController : Controller
    {
        public IActionResult Siga()
        {
            return View();
        }
    }
}