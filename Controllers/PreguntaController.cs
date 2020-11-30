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
    }
}