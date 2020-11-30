using Microsoft.AspNetCore.Mvc;

namespace OfPandaStack.Controllers
{
    public class IngresosController : Controller
    {
        // GET
        public IActionResult Ingreso()
        {
            return View();
        }
        
        public IActionResult Registro()
        {
            return View();
        }
    }
}