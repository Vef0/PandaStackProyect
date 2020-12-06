using Microsoft.AspNetCore.Mvc;

namespace OfPandaStack.Controllers
{
    public class PreguntaController : Controller
    {
        // GET
        public IActionResult Pregunta()
        {
            return View();
        }

        public IActionResult Populares()
        {
            return View();
        }

        public IActionResult SinResp()
        {
            return View();
        }
    }
}