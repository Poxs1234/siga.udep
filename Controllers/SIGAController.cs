using Microsoft.AspNetCore.Mvc;

namespace siga.udep.Controllers
{
    public class SIGAController : Controller
    {
        public IActionResult Siga()
        {
            return View();
        }

        public IActionResult DetalleCurso(string codigo)
        {
            // Aquí puedes buscar el curso por código y mostrar su vista
            // Por ejemplo:
            switch(codigo)
            {
                case "FAF":
                    return View("Antro");
                case "FHD":
                    return View("Derecho");
                case "HC3":
                    return View("Historia");
                case "JP1":
                    return View("Penal");
                case "LF":
                    return View("Logica");
                case "PC1":
                    return View("Consti");
                default:
                    return NotFound();
            }
        }
    }

}

